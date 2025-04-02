using System;
using System.Linq;
using System.Threading;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace BeetleGame
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Beetle beetle;

        public MainWindow()
        {
            InitializeComponent();
            beetle = new Beetle(paperCanvas, 0, 0, 10);
        }

        private void sliderPixelChange(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            sizeLabel.Content = e.NewValue;
            beetle.updateBeetleSize(beetle, Convert.ToInt32(e.NewValue));
        }

        private void speedSliderChange(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            double speedValue = e.NewValue;
            speedValue = Math.Round(speedValue, 1);

            speedLabel.Content = speedValue;
        }

        private void startButton(object sender, RoutedEventArgs e)
        {
            if (_startButton.Content.ToString().ToLower() == "start")
            {
                if (!paperCanvas.Children.OfType<Ellipse>().Any())
                {
                    _speedSlider.IsEnabled = false;
                    _sizeSlider.IsEnabled = false;
                    Ellipse beetleSprite = beetle.createBeetleSprite(Convert.ToInt32(sizeLabel.Content));
                    paperCanvas.Children.Add(beetleSprite);
                }
                _startButton.Content = "Stop";
            }
            else
            {
                _startButton.Content = "Start";
                _speedSlider.IsEnabled = true;
                _sizeSlider.IsEnabled = true;
                messageLabel.Content = "Total distance in meters: " + calculateDistance(paperCanvas, beetle);
                messageLabel.Background = new SolidColorBrush(Colors.LightPink);
            }
        }
        private double calculateDistance(Canvas papercanvas, Beetle beetle)
        {
            return 0;
        }

        private void resetButton(object sender, RoutedEventArgs e)
        {
            _speedSlider.Value = _speedSlider.Minimum;
            _sizeSlider.Value = _sizeSlider.Minimum;
            paperCanvas.Children.Clear();
        }
        private void movementButtonDown(object sender, RoutedEventArgs e)
        {
            Button button = sender as Button;
            beetle.updateBeetleMovement(beetle, paperCanvas, double.Parse(speedLabel.Content.ToString()), button.Content.ToString());
        }
    }
};

