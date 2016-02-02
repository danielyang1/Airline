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
using AwesomeAirlinesLogic;

namespace AwesomeAirlines
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Loaded += MainWindow_Loaded;
        }


        private void button_Click(object sender, RoutedEventArgs e)
        {
            Sounds mySound = new Sounds();
            mySound.potatos();
        }

        private void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            FlightPlan TenAMChicago = new FlightPlan("Chicago", "154", "10:00 am", "10:46 am");
            string routeOne = TenAMChicago.concat();
            FlightPlan TwelvePMChicago = new FlightPlan("Detroit", "155", "12:00 pm", "1:22 pm");
            string routeTwo = TwelvePMChicago.concat();
            FlightPlan TwoPMOmaha = new FlightPlan("Omaha", "156", "2:00 pm", "6:33 pm");
            string routeThree = TwoPMOmaha.concat();
            FlightPlan FiveFifftyNineSanDiego = new FlightPlan("San Diego", "157", "5:59 pm", "12:20 am");
            string routeFour = FiveFifftyNineSanDiego.concat();

            ListOfRoutes.Items.Add(routeOne);
            ListOfRoutes.Items.Add(routeTwo);
            ListOfRoutes.Items.Add(routeThree);
            ListOfRoutes.Items.Add(routeFour);
        }


        private void listBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
