using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Supelevator.Models
{
   public class FireLoadInfo: INotifyPropertyChanged
    {
        private int _id;
        private string _name;
        private double _heatDouble;
        private double _lineSp;
        private double _upSp;
        public int Id
        {
            get { return _id; }
            set
            {
                if (value == _id) return;
                _id = value;
                OnPropertyChanged();
            }
        }
        public string Name
        { 
            get { return _name; }
            set
            {
                if (value == _name) return;
                _name = value;
                OnPropertyChanged();
            }

        }
        public double HeatDouble
        {
            get { return _heatDouble; }
            set
            {
                if (value == _heatDouble) return;
                _heatDouble = value;
                OnPropertyChanged();
            }
        }
        public double LineSp
        {
            get { return _lineSp; }
            set
            {
                if (value == _lineSp) return;
                _lineSp = value;
                OnPropertyChanged();
            }
        }
        public double UpSp
        {
            get { return _upSp; }
            set
            {
                if (value == _upSp) return;
                _upSp = value;
                OnPropertyChanged();
            }
        }
        public event PropertyChangedEventHandler PropertyChanged;
        internal void OnPropertyChanged([CallerMemberName] string propertyName="")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
