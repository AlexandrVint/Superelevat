using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supelevator.ViewModels
{
    public class GsmInRoomClass
    {
        private double _r;
        private double _Qf;
        private double _H;
        private double _h;
        private double _W;
        private double _z;
        private double _koef_completeness_of_fire;
        private double _Q_average;
        private double _specific_speed;
        private double _F0;


        public double r
        {
            get { return _r; }
            set
            {
                _r = value;
            }
        }
        public double Qf
        {
            get { return _Qf; }
            set { _Qf = value; }
        }
        public double H
        {
            get { return _H; }
            set { _H = value; }
        }
        public double h
        {
            get { return _h; }
            set { _h = value; }
        }
        public double W
        {
            get { return _W; }
            set { _W = value; }
        }
        public double z
        {
            get { return _z; }
            set { _z = value; }
        }
        public double Koef_completeness_of_fire
        {
            get { return _koef_completeness_of_fire; }
            set { _koef_completeness_of_fire = value; }
        }
        public double Q_average
        {
            get { return _Q_average; }
            set { _Q_average = value; }
        }
        public double Specific_speed
        {
            get { return _specific_speed; }
            set { _specific_speed = value; }
        }
        public double F0
        {
            get { return _F0; }
            set { _F0 = value; }
        }

    }
}
