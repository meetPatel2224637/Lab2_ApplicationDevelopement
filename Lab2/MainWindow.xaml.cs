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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Lab2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void selectApp_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int choice = selectApp.SelectedIndex;
            switch (choice)
            {
                case 0:
                    PopulationUI pop = new PopulationUI();
                    pop.Show();
                    break;
                   
                   
                case 1:
                    ShippingchargesUI sc = new ShippingchargesUI();
                    sc.Show();
                    break;

                case 2:
                   
                    DistanceTraveledUI dt = new DistanceTraveledUI();
                    dt.Show();
                    break;

                case 3:
                    TestScoresUI ts = new TestScoresUI();
                    ts.Show();
                    break;
            }
        }
    }

}
