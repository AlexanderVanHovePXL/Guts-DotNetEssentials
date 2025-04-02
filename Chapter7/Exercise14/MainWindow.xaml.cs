using System.Windows;

namespace Exercise14
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void _button_Click(object sender, RoutedEventArgs e)
        {
            
            
            CheckSelectedAgeGroup();
            
        }
        private void CheckSelectedAgeGroup()
        {
            if (age18to30.IsChecked == true)
            {
                MessageBox.Show("she young");
            }
            else if (age30to45.IsChecked == true)
            {
                // Code for age between 30 and 45
            }
            else if (age45to60.IsChecked == true)
            {
                // Code for age between 45 and 60
            }
            else if (ageover60.IsChecked == true)
            {
                MessageBox.Show("she old as shit");
            }
        }
    }
}
