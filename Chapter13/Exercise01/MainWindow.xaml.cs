using System.Windows;
using System.Windows.Controls;

namespace Exercise01
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void mylistBox_MouseDoubleClick(object sender, SelectionChangedEventArgs e)
        {
            if (myListBox.SelectedItem != null)
            {
                myListBox.Items.Remove(myListBox.SelectedItem);
            }
        }
    }
}
