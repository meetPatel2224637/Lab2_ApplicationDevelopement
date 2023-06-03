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
    /// Interaction logic for TestScoresUI.xaml
    /// </summary>
    public partial class TestScoresUI : Window
    {
        public TestScoresUI()
        {
            InitializeComponent();
        }

        private void Calculate_Click(object sender, RoutedEventArgs e)
        {
            if (double.TryParse(txtScore1.Text, out double score1) &&
                double.TryParse(txtScore2.Text, out double score2) &&
                double.TryParse(txtScore3.Text, out double score3))
            {
                TestScore testScore = new TestScore(score1, score2, score3);
                double average = testScore.CalculateAverage();
                string letterGrade = testScore.GetLetterGrade();

                txtResult.Text = $"Average Score: {average}\nLetter Grade: {letterGrade}";
            }
            else
            {
                MessageBox.Show("Invalid input! Please enter valid test scores.");
            }
        }




    }

    public class TestScore
    {
        private double score1;
        private double score2;
        private double score3;

        public TestScore(double score1, double score2, double score3)
        {
            this.score1 = score1;
            this.score2 = score2;
            this.score3 = score3;
        }

        public double CalculateAverage()
        {
            return (score1 + score2 + score3) / 3;
        }

        public string GetLetterGrade()
        {
            double average = CalculateAverage();

            if (average >= 90)
            {
                return "A";
            }
            else if (average >= 80)
            {
                return "B";
            }
            else if (average >= 70)
            {
                return "C";
            }
            else if (average >= 60)
            {
                return "D";
            }
            else
            {
                return "F";
            }
        }
    }

}
