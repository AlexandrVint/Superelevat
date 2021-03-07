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






namespace Supelevator.Models
{
    public class Distance
    {
        // поля точек отрезка дистанции


        // координаты точку при указке мышью
        public double _mousePoint_X { get; set; }

        public double _mousePoint_Y { get; set; }




        Point check_point = new Point();

        public double check_point_X { get; set; }

        public double check_point_Y { get; set; }

        // свойство первой точки отрезка дистанции (координаты)
        public double x_point1 { get; set; }
        public double y_point1 { get; set; }


        // свойство второй точки отрезка дистанции (координаты)
        public double x_point2 { get; set; }
        public double y_point2 { get; set; }


        //public double distance_x (double point1_x, double point2_x)
        //{
        //    x_point1 = point1_x;
        //    x_point2 = point2_x;

        //    double distance_x = Math.Abs(x_point1 - x_point2);
        //    return distance_x;
        //}
        //public double distance_y(double point1_y, double point2_y)
        //{
        //    y_point1 = point1_y;
        //    y_point2 = point2_y;

        //    double distance_y = Math.Abs(y_point1 - y_point2);
        //    return distance_y;
        //}
        

        public void distance_check (double x1, double x2, double y1, double y2, double _mousePoint_X, double _mousePoint_Y)
        {

            double bisector_point1_check = Math.Sqrt(Math.Pow((x1 - _mousePoint_X), 2) + Math.Pow((y1 - _mousePoint_Y), 2));
            double bisector_point2_check = Math.Sqrt(Math.Pow((x2 - _mousePoint_X), 2) + Math.Pow((y2 - _mousePoint_Y), 2));

            if (bisector_point1_check < bisector_point2_check & bisector_point1_check<100)
            {
                check_point.X = x_point1;
                check_point_X = check_point.X;
                check_point.Y = y_point1;
                check_point_Y = check_point.Y;
            }
            else if (bisector_point2_check< bisector_point1_check & bisector_point2_check<100)
            {
                check_point.X = x_point2;
                check_point_X = check_point.X;
                check_point.Y = y_point2;
                check_point_Y = check_point.Y;
            }
            


        }


        


    }
}
