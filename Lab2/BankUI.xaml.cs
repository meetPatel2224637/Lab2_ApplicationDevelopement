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
    /// Interaction logic for BankUI.xaml
    /// </summary>
    public partial class BankUI : Window
    {
        public BankUI()
        {
            InitializeComponent();
        }

        private void CalculateButton_Click(object sender, RoutedEventArgs e)
        {
            if (double.TryParse(txtEndingBalance.Text, out double endingBalance) &&
                int.TryParse(txtNumberOfChecks.Text, out int numberOfChecks))
            {
                BankCharges bankCharges = new BankCharges(endingBalance, numberOfChecks);
                double serviceFees = bankCharges.CalculateBankingServiceFees();

                txtResult.Text = $"Service Fees: {serviceFees:C}";
            }
            else
            {
                MessageBox.Show("Invalid input! Please enter valid values for ending balance and number of checks.");
            }
        }
        internal class BankCharges
        {
            private double endingBalance;
            private int numberOfChecks;

            public BankCharges(double endingBalance, int numberOfChecks)
            {
                this.endingBalance = endingBalance;
                this.numberOfChecks = numberOfChecks;
            }

            public double CalculateBankingServiceFees()
            {
                double serviceFees = 10.0;

                if (endingBalance < 400.0)
                {
                    serviceFees += 15.0;
                }

                if (numberOfChecks < 20)
                {
                    serviceFees += numberOfChecks * 0.10;
                }
                else if (numberOfChecks >= 20 && numberOfChecks <= 39)
                {
                    serviceFees += numberOfChecks * 0.08;
                }
                else if (numberOfChecks >= 40 && numberOfChecks <= 59)
                {
                    serviceFees += numberOfChecks * 0.06;
                }
                else if (numberOfChecks >= 60)
                {
                    serviceFees += numberOfChecks * 0.04;
                }

                return serviceFees;
            }
        }
    }
}
