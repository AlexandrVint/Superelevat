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




namespace Supelevator.Models
{
    public class Distance
    {
        // поля точек отрезка дистанции
        double X_point1;
        double Y_point1;

        double X_point2;
        double Y_point2;

        Point mousePoint = new Point();

        // координаты точку при указке мышью
        double _mousePoint_X
        {
            get
            {
                return mousePoint.X;
            }
            set
            {
                _mousePoint_X = value;
                mousePoint.X = _mousePoint_X;
            }
        }
        double _mousePoint_Y
        {
            get
            {
                return mousePoint.Y;
            }
            set
            {
                _mousePoint_Y = value;
                mousePoint.Y = _mousePoint_Y;
            }
        }




        Point check_point = new Point();

        

        // свойство первой точки отрезка дистанции (координаты)
        double x_point1
        {
            get
            {
                return X_point1;
            }
            set
            {
                x_point1 = value;
                X_point1 = x_point1;
            }
        }
        double y_point1
        {
            get
            {
                return Y_point1;
            }
            set
            {
                y_point1 = value;
                Y_point1 = y_point1;
            }
        }


        // свойство второй точки отрезка дистанции (координаты)
        double x_point2
        {
            get
            {
                return X_point2;
            }
            set
            {
                x_point2 = value;
                X_point2 = x_point2;
            }
        }
        double y_point2
        {
            get
            {
                return Y_point2;
            }
            set
            {
                y_point2 = value;
                Y_point2 = y_point2;
            }
        }


        public double distance_x (double point1_x, double point2_x)
        {
            x_point1 = point1_x;
            x_point2 = point2_x;

            double distance_x = Math.Abs(x_point1 - x_point2);
            return distance_x;
        }
        public double distance_y(double point1_y, double point2_y)
        {
            y_point1 = point1_y;
            y_point2 = point2_y;

            double distance_y = Math.Abs(y_point1 - y_point2);
            return distance_y;
        }
        

        public void distance_check (double x1, double x2, double y1, double y2, double _mousePoint_X, double _mousePoint_Y)
        {

            double bisector_point1_check = Math.Sqrt(Math.Pow((x1 - _mousePoint_X), 2) + Math.Pow((y1 - _mousePoint_Y), 2));
            double bisector_point2_check = Math.Sqrt(Math.Pow((x2 - _mousePoint_X), 2) + Math.Pow((y2 - _mousePoint_Y), 2));

            if (bisector_point1_check< bisector_point2_check)
            {
                check_point.X = x_point1;
                check_point.Y = y_point1;
            }
            else if (bisector_point2_check< bisector_point1_check)
            {
                check_point.X = x_point2;
                check_point.Y = y_point2;
            }
            
        }



    }
}
