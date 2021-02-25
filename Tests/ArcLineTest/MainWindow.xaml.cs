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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ArcLineTest
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        bool Move;
        public int Mode = 1;
        int [] lines = new int[300];

        List<Point> points = new List<Point>();


        public MainWindow()
        {
            InitializeComponent();
        }

        Point currentPoint1 = new Point();
        Point currentPoint2 = new Point();




        private void paintLine_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ButtonState==MouseButtonState.Pressed)
            {
                currentPoint1 = e.GetPosition(this);
                


            }
        }

        private void paintLine_MouseUp(object sender, MouseButtonEventArgs e)
        {
            if(e.LeftButton == MouseButtonState.Released)
            {
                currentPoint2 = e.GetPosition(this);
                Move = true;
            }    
        }
        // устанаваливаем ружим рисования линии
        //private void SetLinePosition(int mode)
        //{
        //    Line line = new Line();
        //    if (Line == null) return;
        //    switch (mode)
        //    {
        //        case 1: //стандарт
        //            Line.X2 = Mouse.GetPosition(this).X - canvas.Margin.Left;
        //            Line.Y2 = Mouse.GetPosition(this).Y - canvas.Margin.Top;
        //            break;

        //        case 2: //по углом 45 градусов слева
        //            Line.X2 = Mouse.GetPosition(this).X - canvas.Margin.Left;
        //            Line.Y2 = Line.Y1 - (Line.X1 - Mouse.GetPosition(this).X + canvas.Margin.Left);
        //            break;

        //        case 3: //по углом 45 градусов справа
        //            Line.X2 = Mouse.GetPosition(this).X - canvas.Margin.Left;
        //            Line.Y2 = Line.Y1 + (Line.X1 - Mouse.GetPosition(this).X + canvas.Margin.Left);
        //            break;

        //        case 4: //по вертикале
        //            Line.X2 = Line.X1;
        //            Line.Y2 = Mouse.GetPosition(this).Y - canvas.Margin.Top;
        //            break;

        //        case 5: //по горизонтале
        //            Line.X2 = Mouse.GetPosition(this).X - canvas.Margin.Left;
        //            Line.Y2 = Line.Y1;
        //            break;
        //    }





            private void paintLine_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.LeftButton==MouseButtonState.Pressed)
            {
                currentPoint2 = e.GetPosition(paintLine);
                DrawLine(currentPoint1, currentPoint2, true);

            }  
        }
        private void DrawLine(Point start, Point stop, bool move)
        {
            Line line = new Line();
            line.Stroke = Brushes.Green;
            line.StrokeThickness = 5;
            line.X1 = start.X;
            line.Y1 = start.Y;
            line.X2 = stop.X;
            line.Y2 = stop.Y;

                if (!move)
                    paintLine.Children.Add(line);

                else
                    if (paintLine.Children.Count > 2 && !Move)
                {

                    paintLine.Children.RemoveAt(paintLine.Children.Count - 1);
                    paintLine.Children.Add(line);


                }
                else
                {
                    paintLine.Children.Add(line);
                    Move = false;
                }
            


        }

    }
}
