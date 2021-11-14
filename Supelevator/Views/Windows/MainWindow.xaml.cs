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
using Supelevator.Views.Windows;


namespace Supelevator
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

        public void Button3_Click(object sender, RoutedEventArgs e)
        {
            CalcSmokeCorridor1 CalcSmokeCorridorWindow = new CalcSmokeCorridor1();
            CalcSmokeCorridorWindow.Show();

            this.Close();
        }

        private void Button2_Click(object sender, RoutedEventArgs e)
        {
            CalcSmokeRoom1 CalcSmokeRoom1Window = new CalcSmokeRoom1();
            CalcSmokeRoom1Window.Show();
            this.Close();


        }
    }
}
