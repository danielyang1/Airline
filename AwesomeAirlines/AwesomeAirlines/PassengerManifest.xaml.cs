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
using AwesomeAirlinesLogic;

namespace AwesomeAirlines
{
    /// <summary>
    /// Interaction logic for PassengerManifest.xaml
    /// </summary>
    public partial class PassengerManifest : Window
    {
        public PassengerManifest()
        {
            InitializeComponent();
            Loaded += PassengerManifest_Loaded;
        }

        private void PassengerManifest_Loaded(object sender, RoutedEventArgs e)
        {
            Manifest Main = new Manifest();

            FileRead readWrite = new FileRead();

            readWrite.FileReader();




            foreach (Passenger id in readWrite.PassManifest)
            {
                
            }
        }
    }
}
