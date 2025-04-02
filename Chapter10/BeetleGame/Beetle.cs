using System;
using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;
using System.Windows;
using System.Windows.Automation.Peers;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;

namespace BeetleGame
{
    public class Beetle
    {
        private Ellipse beetleSprite { get; set; }
        private Canvas paperCanvas { get; set; }
        private int x { get; set; }
        private int y { get; set; }
        private int size { get; set; }

        public Beetle(Canvas PaperCanvas, int X, int Y, int Size)
        {
            beetleSprite = new Ellipse();
            paperCanvas = PaperCanvas;
            x = X;
            y = Y;
            size = Size;
        }
        public Ellipse createBeetleSprite(int width)
        {
            
            beetleSprite.Stroke = new SolidColorBrush(Colors.Red);
            beetleSprite.Fill = new SolidColorBrush(Colors.Red);
            beetleSprite.Width = width;
            beetleSprite.Height = width;
            beetleSprite.Margin = new Thickness(0, 0, 0, 0);
            return beetleSprite;
        }
        public void updateBeetleSize(Beetle beetle, int width)
        {
            beetle.beetleSprite.Width = width;
            beetle.beetleSprite.Height = width;
        }
        
        public void updateBeetleMovement(Beetle beetle, Canvas paperCanvas, double speed, string direction)
        {

            Thickness currentMargin = beetle.beetleSprite.Margin;
            if (direction.ToLower().Contains("down"))
            {
                currentMargin.Top += speed;
                if (currentMargin.Top + beetle.beetleSprite.Height >= paperCanvas.ActualHeight)
                {
                    currentMargin.Top += speed;
                }
            }
            else if (direction.ToLower().Contains("up"))
            {
                currentMargin.Top -= speed;
            }
            else if (direction.ToLower().Contains("left"))
            {
                currentMargin.Left -= speed;
            } else
            {
                currentMargin.Left += speed;
            }
            beetle.beetleSprite.Margin = currentMargin;
        }
        

    }
}

