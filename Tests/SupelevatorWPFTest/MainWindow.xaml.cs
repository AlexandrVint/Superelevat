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



namespace SupelevatorWPFTest
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

        }

        List <Point> Points = new List<Point>
                {
            new Point(60, 150),
            new Point(180, 20),
            new Point(300, 60),
            new Point(350, 120),
            new Point(20, 90),
            new Point(120, 50),
            new Point(330, 20),
            new Point(310, 180)
                };

        private void Grid_MouseMove(object sender, MouseEventArgs e)
        {
            double Sqr(double x) => x * x;
            double Distance(Point p1, Point p2) => Math.Sqrt(Sqr(p1.X - p2.X) + Sqr(p1.Y - p2.Y));
            var coords = e.GetPosition((FrameworkElement)sender);
            var nearbyPoint = Points.OrderBy(p => Distance(p, coords)).First();
            if (Distance(nearbyPoint, coords) < 30.0) coords = nearbyPoint;
            MyLine.X2 = coords.X;
            MyLine.Y2 = coords.Y;
        }

    }
}






