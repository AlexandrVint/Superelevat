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

namespace CheckPointDistance
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

        Point point1 = new Point(100, 100);
        
        Point point2 = new Point(200, 200);
        Point point3 = new Point(300, 200);
        Point point4 = new Point(150, 150);
        Point point5 = new Point(250, 250);

        Point pointX = new Point();
        List<Ellipse> listEl = new List<Ellipse>();

        List<Point> list_points = new List<Point>();
        
        


        public void Canvas_Loaded(object sender, RoutedEventArgs e)
        {


            


            Ellipse el1 = new Ellipse();
            Ellipse el2 = new Ellipse();
            Ellipse el3 = new Ellipse();
            Ellipse el4 = new Ellipse();
            Ellipse el5 = new Ellipse();


            el1.Width = 10;
            el1.Height = 10;
            el1.StrokeThickness = 5;
            el1.Stroke = Brushes.Blue;
            el1.Margin = new Thickness(point1.X - 5, point1.Y - 5, 0, 0);

            

            el2.Width = 10;
            el2.Height = 10;
            el2.StrokeThickness = 5;
            el2.Stroke = Brushes.Blue;
            el2.Margin = new Thickness(point2.X - 5, point2.Y - 5, 0, 0);

            el3.Width = 10;
            el3.Height = 10;
            el3.StrokeThickness = 5;
            el3.Stroke = Brushes.Blue;
            el3.Margin = new Thickness(point3.X - 5, point3.Y - 5, 0, 0);

            el4.Width = 10;
            el4.Height = 10;
            el4.StrokeThickness = 5;
            el4.Stroke = Brushes.Blue;
            el4.Margin = new Thickness(point4.X - 5, point4.Y - 5, 0, 0);

            el5.Width = 10;
            el5.Height = 10;
            el5.StrokeThickness = 5;
            el5.Stroke = Brushes.Blue;
            el5.Margin = new Thickness(point5.X - 5, point5.Y - 5, 0, 0);




            Canvas.Children.Add(el1);
            Canvas.Children.Add(el2);
            Canvas.Children.Add(el3);
            Canvas.Children.Add(el4);
            Canvas.Children.Add(el5);


            listEl.Add(el1);
            listEl.Add(el2);
            listEl.Add(el3);
            listEl.Add(el4);
            listEl.Add(el5);

           

       

        }

        public void distance(Point poin1, Point point2, double X, double Y)
        {

            pointX.X = Mouse.GetPosition(Canvas).X;
            pointX.Y = Mouse.GetPosition(Canvas).Y;
            double dis1 = Math.Sqrt(Math.Pow((point1.X - pointX.X), 2) + Math.Pow((point1.Y - pointX.Y), 2));
            double dis2 = Math.Sqrt(Math.Pow((point2.X - pointX.X), 2) + Math.Pow((point2.Y - pointX.Y), 2));

            if (dis1<dis2 & dis1<30)
            {
                pointX.X = point1.X;
                pointX.Y = point1.Y;

            }
            else if (dis2<dis1 & dis2<30)
            {
                pointX.X = point2.X;
                pointX.Y = point2.Y;
            }

        }

        public void Canvas_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
           if (listEl.Count != 0)
            {
                distance(point1, point2, pointX.X, pointX.Y);


                Ellipse elX = new Ellipse();
                elX.Width = 10;
                elX.Height = 10;
                elX.StrokeThickness = 5;
                elX.Stroke = Brushes.Red;
                elX.Margin = new Thickness(pointX.X - 5, pointX.Y - 5, 0, 0);


                
                Canvas.Children.Add(elX);
                listEl.Add(elX);

            }

        }



    }

}
