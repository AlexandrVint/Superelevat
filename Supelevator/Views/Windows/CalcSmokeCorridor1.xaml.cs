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
using Supelevator.Views.Windows;
using System.Data.SQLite;



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

            TextBlock1.Focusable = false;
            
        }

        public int mode;


        List<Line> lines = new List<Line>();
        List<Point> points = new List<Point>();
        
        List<double> listPointsX = new List<double>();
        List<double> listPointsY = new List<double>();
        Point point1 = new Point();
        Point point2 = new Point();
        Point point3 = new Point();
        Point point4 = new Point();




        private void RibbonButton_Click(object sender, RoutedEventArgs e)
        {
            UserControl_Loaded(this, e);
            var window = Window.GetWindow(this);
            window.KeyDown += HandleKeyPress;
            CalcSmokeCorridor1 focus = new CalcSmokeCorridor1();
            


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
            else if (e.Key == Key.Escape)
                mode = 0;
            else if (e.Key == Key.Space)
            {
                mode = 4;


            }


        }
        protected void UnRegister()
        {
            var window = Window.GetWindow(this);
            window.KeyDown -= HandleKeyPress;
        }

        private void Canvas_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
          
                point1 = Mouse.GetPosition(Canvas);
                points.Add(point1);

                listPointsX.Add(point1.X);
                listPointsY.Add(point1.Y);


            









        }

        internal void Canvas_MouseMove(object sender, MouseEventArgs e)
        {



        }

        private void Canvas_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
 
                point2 = Mouse.GetPosition(Canvas);
                points.Add(point2);
                listPointsX.Add(point2.X);
                listPointsY.Add(point2.Y);
            


            DrawLine(point1, point2, true);
            point3 = point2;
            points.Add(point3);

            point4 = Mouse.GetPosition(Canvas);
            points.Add(point4);
            DrawLine(point3, point4, true);
            listPointsX.Add(point4.X);
            listPointsY.Add(point4.Y);




        }
        

        public void Canvas_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Q)
                mode = 2;
            else if (e.Key == Key.W)
                mode = 3;
            else if (e.Key == Key.E)
                mode = 1;
            else if (e.Key == Key.Escape)
                mode = 0;
            else if (e.Key == Key.Space)
            {
                mode = 4;



            }


        }

       
        





    public void DrawLine(Point start, Point stop, bool move)
        {
            
            Ellipse el1 = new Ellipse();
            el1.Width = 10;
            el1.Height = 10;
            el1.StrokeThickness = 10;
            el1.Fill = Brushes.Blue;
            Ellipse el2 = new Ellipse();
            el2.Width = 10;
            el2.Height = 10;
            el2.StrokeThickness = 10;
            el2.Fill = Brushes.Blue;
            Line line = new Line();
            line.Stroke = Brushes.White;
            line.StrokeThickness = 2;




            if (lines.Count == 0)
            {
                switch (mode)
                {
                    case 0: // сброс рисования
                        mode = 0;
                        break;

                    case 1: // стандартная линия
                        line.X1 = start.X;
                        line.Y1 = start.Y;
                        line.X2 = stop.X;
                        line.Y2 = stop.Y;
                        el1.Margin = new Thickness(line.X1 - 5, line.Y1 - 5, 0, 0);
                        Canvas.Children.Add(el1);
                        Canvas.Children.Add(line);


                        lines.Add(line);


                        break;
                    case 2: // горизонтальная линия
                        line.X1 = start.X;
                        line.Y1 = start.Y;
                        line.X2 = stop.X;
                        line.Y2 = line.Y1;

                        el1.Margin = new Thickness(line.X1 - 5, line.Y1 - 5, 0, 0);
                        Canvas.Children.Add(el1);

                        Canvas.Children.Add(line);
                        lines.Add(line);


                        break;
                    case 3: // вертикальная линия
                        line.Y1 = start.Y;
                        line.X1 = start.X;
                        line.Y2 = stop.Y;
                        line.X2 = line.X1;

                        el1.Margin = new Thickness(line.X1 - 5, line.Y1 - 5, 0, 0);
                        Canvas.Children.Add(el1);

                        Canvas.Children.Add(line);
                        lines.Add(line);
                        break;

                }
            }
            else
            {

                switch (mode)
                {
                    case 0: // сброс рисования
                        mode = 0;
                        break;


                    case 1: // стандартная линия

                        line.X1 = lines[lines.Count - 1].X2;
                        line.X2 = Mouse.GetPosition(Canvas).X;
                        line.Y1 = lines[lines.Count - 1].Y2;
                        line.Y2 = Mouse.GetPosition(Canvas).Y;

                        Canvas.Children.Add(line);

                        el2.Margin = new Thickness(line.X2 - 5, line.Y2 - 5, 0, 0);
                        Canvas.Children.Add(el2);


                        lines.Add(line);


                        break;
                    case 2: // горизонтальная линия
                        line.X1 = lines[lines.Count - 1].X2;
                        line.Y1 = lines[lines.Count - 1].Y2;
                        line.X2 = Mouse.GetPosition(Canvas).X;
                        line.Y2 = line.Y1;
                        Canvas.Children.Add(line);

                        el2.Margin = new Thickness(line.X2 - 5, line.Y2 - 5, 0, 0);
                        Canvas.Children.Add(el2);

                        lines.Add(line);

                        break;
                    case 3: // вертикальная линия
                        line.X1 = lines[lines.Count - 1].X2;
                        line.Y1 = lines[lines.Count - 1].Y2;
                        line.X2 = line.X1;
                        line.Y2 = Mouse.GetPosition(Canvas).Y;

                        el2.Margin = new Thickness(line.X2 - 5, line.Y2 - 5, 0, 0);
                        Canvas.Children.Add(el2);

                        Canvas.Children.Add(line);
                        lines.Add(line);

                        break;

                    case 4: // сброс рисования и рисование линий с произвольной точкой
                        line.X1 = Mouse.GetPosition(Canvas).X;
                        line.Y1 = Mouse.GetPosition(Canvas).Y;
                        line.X2 = Mouse.GetPosition(Canvas).X;
                        line.Y2 = Mouse.GetPosition(Canvas).Y;

                        el2.Margin = new Thickness(line.X2 - 5, line.Y2 - 5, 0, 0);
                        Canvas.Children.Add(el2);
                        Canvas.Children.Add(line);

                        lines.Add(line);

                        break;

                }

            }


            //if (line != null)
            //{
            //    switch (mode)
            //    {
            //        case 1: // стандартная линия
            //            line.X1 = start.X;
            //            line.Y1 = start.Y;
            //            line.X2 = stop.X;
            //            line.Y2 = stop.Y;
            //            Canvas.Children.Add(line);

            //            break;
            //        case 2: // горизонтальная линия
            //            line.X1 = start.X;
            //            line.Y1 = start.Y;
            //            line.X2 = stop.X;
            //            line.Y2 = line.Y1;
            //            Canvas.Children.Add(line);
            //            break;
            //        case 3: // вертикальная линия
            //            line.Y1 = start.Y;
            //            line.X1 = start.X;
            //            line.Y2 = stop.Y;
            //            line.X2 = line.X1;
            //            Canvas.Children.Add(line);
            //            break;
            //    }
            //}

        }


        //public void DrawLine_next(Point start, Point stop, bool move)
        //{
        //    point3 = Mouse.GetPosition(Canvas);
        //    for (int i=3; i<1000; i++)
        //    {
        //        listPointsX.Add (point3.X);
        //        listPointsY.Add(point3.Y);
        //    }
        //    //DrawLine(point2, point3, true);

        //}

        private void Canvas_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            //Line line = new Line();
            //line.Stroke = Brushes.White;
            //line.StrokeThickness = 1;


        }

        private void Canvas_MouseEnter(object sender, MouseEventArgs e)
        {
            TextBlock1.Focusable = false;
           
        }

        private void Canvas_MouseLeave(object sender, MouseEventArgs e)
        {
            Canvas.Focusable = false;
        }

        private void TextBlock1_MouseEnter(object sender, MouseEventArgs e)
        {
            TextBlock1.Focusable = true;
        }

        
        private void TextBlock1_MouseLeave(object sender, MouseEventArgs e)
        {
            
            TextBlock1.Focusable = false;
        }




        
    }
    
}
