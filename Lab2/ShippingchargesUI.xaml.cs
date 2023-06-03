using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Lab2
{
    /// <summary>
    /// Interaction logic for ShippingchargesUI.xaml
    /// </summary>
    public partial class ShippingchargesUI : Window
    {
        public ShippingchargesUI()
        {
            InitializeComponent();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            double _weight = Double.Parse(weight.Text);
            ShippingCharges sc = new ShippingCharges(_weight);
            displayFees.SetValue(Label.ContentProperty, sc.calculateShippingCharge(Double.Parse(miles.Text)).ToString());
        }
    }

    class ShippingCharges
    {
        private double weight;

        public ShippingCharges(double weight)
        {
            this.weight = weight;
        }

        public double _weight
        {
            get { return weight; }
            set { weight = value; }
        }

        public double getShippingRate()
        {
            if (weight <= 2)
            {
                return 1.10;
            }
            else if (weight > 2 && weight <= 6)
            {
                return 2.20;
            }
            else if (weight > 6 && weight <= 10)
            {
                return 3.70;
            }
            else
            {
                return 4.80;
            }
        }

        public double calculateShippingCharge(double miles)
        {
            return getShippingRate() * (int)Math.Ceiling(miles / 500);
        }
    }
}
