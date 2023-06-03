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
    /// Interaction logic for DistanceTraveledUI.xaml
    /// </summary>
    public partial class DistanceTraveledUI : Window
    {
        public DistanceTraveledUI()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            double _speed = Double.Parse(speed.Text);
            double _time = Double.Parse(time.Text);
            DistanceTraveled dt = new DistanceTraveled(_speed, _time);
            displayDistance.SetValue(Label.ContentProperty, dt.getDistance().ToString());
        }
    }

   
    class DistanceTraveled
    {
        private double speed;
        private double travelTime;

        public DistanceTraveled(double speed, double travelTime)
        {
            this.speed = speed;
            this.travelTime = travelTime;
        }

        public double _Speed
        {
            get { return speed; }
            set { speed = value; }
        }

        public double _TravelTime
        {
            get { return travelTime; }
            set { travelTime = value; }
        }

        public double getDistance()
        {
            return speed * travelTime;
        }
    }
}
