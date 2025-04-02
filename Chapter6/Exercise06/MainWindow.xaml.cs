using System;
using System.Windows;
using System.Windows.Threading;

namespace Exercise06
{
    public partial class MainWindow : Window
    {
        private DispatcherTimer _dispatcherTimer = new DispatcherTimer();
        public MainWindow()
        {
            InitializeComponent();

            _dispatcherTimer.Interval = TimeSpan.FromSeconds(1);
            _dispatcherTimer.Tick += _dispatcherTimer_Tick;
            _dispatcherTimer.Start();
        }
        private void _dispatcherTimer_Tick(object sender, EventArgs e)
        {
            if (_minutesRectangle.Width == 600)
            {
                _minutesRectangle.Width = 0;
            }
            if (_secondsRectangle.Width == 600)
            {
                _minutesRectangle.Width += 10;
                _secondsRectangle.Width = 0;
            }
            _secondsRectangle.Width += 10;
        }
    }
}
