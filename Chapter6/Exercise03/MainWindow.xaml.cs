using System;
using System.Windows;
using System.Windows.Automation;

namespace Exercise03
{
    public partial class MainWindow : Window
    {
        private static int amountOfRolls = 0;
        private static int sum = 0;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void _theButton_Click(object sender, RoutedEventArgs e)
        {
            randomTextBox.IsEnabled = true;
            _sumTextBox.IsEnabled = true;
            _averageTextBox.IsEnabled = true;
            Random random = new Random();
            int randomNumber = random.Next(200, 400);
            amountOfRolls++;
            randomTextBox.Text = randomNumber.ToString();
            sum += randomNumber;
            _sumTextBox.Text = sum.ToString();
            double average = (double) sum / amountOfRolls;
            _averageTextBox.Text = Math.Round(average, 2).ToString();

        }
    }
}
