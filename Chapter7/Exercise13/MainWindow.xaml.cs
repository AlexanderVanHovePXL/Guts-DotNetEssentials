using System;
using System.Windows;

namespace Exercise13
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void _button_Click(object sender, RoutedEventArgs e)
        {
            double nettoPrijs = Convert.ToDouble(_priceTextBox.Text);
            if (_checkBox.IsChecked == true)
            {
                double totaal = nettoPrijs * 1.06;
                double btw = totaal - nettoPrijs;
                _btwTextBox.Text = Convert.ToString(btw);
                _totalTextBox.Text = Convert.ToString(totaal);
                _checkBox.IsChecked = false;
            } else
            {
                double totaal = nettoPrijs * 1.21;
                double btw = totaal - nettoPrijs;
                _btwTextBox.Text = Convert.ToString(btw);
                _totalTextBox.Text = Convert.ToString(totaal);
                _checkBox.IsChecked = false;
            }
        }
    }
}
