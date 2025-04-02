using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
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

namespace Exercise04
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            drawStairs();
        }

        public void drawStairs()
        {
            double x = 5;
            canvas.Children.Clear();
            for (int i = 0; i < 4; i++)
            {
                double y = 5;
                for (int j = 0; j < 4; j++)
                {
                    drawRectangle(x, y, 40, 40);
                    x += 10;
                }
                y += 20;
            }
        }
        
        public void drawRectangle(double x, double y, double width, double height)
        {
            Rectangle square = new Rectangle()
            {
                Stroke = new SolidColorBrush(Colors.Black),
                Width = width,
                Height = height,
                Margin = new Thickness(x, y, 0, 0)
            };
            canvas.Children.Add(square);
        }
    }
}
