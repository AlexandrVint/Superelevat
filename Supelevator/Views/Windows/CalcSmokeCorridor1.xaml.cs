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

namespace Supelevator.Views.Windows
{
    /// <summary>
    /// Логика взаимодействия для CalcSmokeCorridor1.xaml
    /// </summary>
    public partial class CalcSmokeCorridor1 : Window
    {
        public CalcSmokeCorridor1()
        {
            InitializeComponent();
            
        }

        public int mode;



        List<double> listPointsX = new List<double>();
        List<double> listPointsY = new List<double>();
        Point point1 = new Point();
        Point point2 = new Point();
        bool draw;


        private void RibbonButton_Click(object sender, RoutedEventArgs e)
        {
            UserControl_Loaded(this, e);
            var window = Window.GetWindow(this);
            window.KeyDown += HandleKeyPress;


        }


        public void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            //var window = Window.GetWindow(this);
            //window.KeyDown += HandleKeyPress;
            //window.KeyDown -= HandleKeyPress;
        }
        private void HandleKeyPress(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Q)
                mode = 2;
            else if (e.Key == Key.W)
                mode = 3;
            else if (e.Key == Key.E)
                mode = 1;
        }
        protected void UnRegister()
        {
            var window = Window.GetWindow(this);
            window.KeyDown -= HandleKeyPress;
        }

        private void Canvas_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            point1 = Mouse.GetPosition(Canvas);
            listPointsX.Add(point1.X);
            listPointsY.Add(point1.Y);
            draw = true;

        }

        private void Canvas_MouseMove(object sender, MouseEventArgs e)
        {
            if(draw)
            {
                Point p = Mouse.GetPosition(Canvas);
            }
        }

        private void Canvas_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            draw = false;
            if (draw == false)
            {
                point2 = Mouse.GetPosition(Canvas);
                listPointsX.Add(point2.X);
                listPointsY.Add(point2.Y);
                DrawLine(point1, point2, true);
            }
        }

        public void Canvas_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Q)
                mode = 2;
            else if (e.Key == Key.W)
                mode = 3;
            else if (e.Key == Key.E)
                mode = 1;
        }

        public void DrawLine(Point start, Point stop, bool move)
        {
            Line line = new Line();
            line.Stroke = Brushes.White;
            line.StrokeThickness = 1;
            
            switch (mode)
            {
                case 1: // стандартная линия
                    line.X1 = start.X;
                    line.Y1 = start.Y;
                    line.X2 = stop.X;
                    line.Y2 = stop.Y;
                    Canvas.Children.Add(line);
                    break;
                case 2: // горизонтальная линия
                    line.X1 = start.X;
                    line.Y1 = start.Y;
                    line.X2 = stop.X;
                    line.Y2 = line.Y1;
                    Canvas.Children.Add(line);
                    break;
                case 3: // вертикальная линия
                    line.Y1 = start.Y;
                    line.X1 = start.X;
                    line.Y2 = stop.Y;
                    line.X2 = line.X1;
                    Canvas.Children.Add(line);
                    break;
            }
        }

        private void Canvas_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            Line line = new Line();
            line.Stroke = Brushes.White;
            line.StrokeThickness = 2;

            if (e.Key == Key.LeftShift)
            {
                point1.X = Mouse.GetPosition(Canvas).X - Canvas.Margin.Left;
                point2.X = Mouse.GetPosition(Canvas).X - Canvas.Margin.Left;
                point1.Y = Mouse.GetPosition(Canvas).Y - Canvas.Margin.Top;
                point2.Y = point1.Y;
                line.X1 = point1.X;
                line.X2 = point2.X;
                line.Y1 = point1.Y;
                line.Y2 = line.Y1;
                Canvas.Children.Add(line);
            }
        }


    }
}
