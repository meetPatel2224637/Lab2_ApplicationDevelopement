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
    /// Interaction logic for PopulationUI.xaml
    /// </summary>
    public partial class PopulationUI : Window
    {
        public PopulationUI()
        {
            InitializeComponent();
        }


        private void CalculateButton_Click(object sender, RoutedEventArgs e)
        {
            if (int.TryParse(txtStartingSize.Text, out int startingSize) &&
                double.TryParse(txtDailyIncrease.Text, out double dailyIncrease) &&
                int.TryParse(txtNumberOfDays.Text, out int numberOfDays))
            {
                Population population = new Population(startingSize, dailyIncrease, numberOfDays);
                string result = population.CalculatePopulationPrediction();

                txtResult.Text = result;
            }
            else
            {
                MessageBox.Show("Invalid input! Please enter valid values for starting size, daily increase, and number of days.");
            }
        }




    }


    internal class Population
    {
        private int startingSize;
        private double dailyIncrease;
        private int numberOfDays;

        public Population(int startingSize, double dailyIncrease, int numberOfDays)
        {
            this.startingSize = startingSize;
            this.dailyIncrease = dailyIncrease;
            this.numberOfDays = numberOfDays;
        }

        public string CalculatePopulationPrediction()
        {
            string result = "   Day \t Population\n";
            result += "************************\n";

            double population = startingSize;

            for (int day = 1; day <= numberOfDays; day++)
            {
                result += day + "\t" + population.ToString("F2") + "\n";
                population += population * (dailyIncrease / 100.0);
            }

            return result;
        }
    }
}
