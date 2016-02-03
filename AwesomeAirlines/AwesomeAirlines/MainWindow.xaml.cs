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



        private void Flight1_Checked(object sender, RoutedEventArgs e)
        {
            Flight1.IsChecked = true;
            Flight2.IsChecked = false;
            Flight3.IsChecked = false;
            Flight4.IsChecked = false;
        }

        private void Flight2_Checked(object sender, RoutedEventArgs e)
        {
            Flight1.IsChecked = false;
            Flight2.IsChecked = true;
            Flight3.IsChecked = false;
            Flight4.IsChecked = false;
        }

        private void _3_Checked(object sender, RoutedEventArgs e)
        {
            Flight1.IsChecked = false;
            Flight2.IsChecked = false;
            Flight3.IsChecked = true;
            Flight4.IsChecked = false;
        }

        private void Flight4_Checked(object sender, RoutedEventArgs e)
        {
            Flight1.IsChecked = false;
            Flight2.IsChecked = false;
            Flight3.IsChecked = false;
            Flight4.IsChecked = true;
        }
        private void Select_Click(object sender, RoutedEventArgs e)
        {
            if (this.Flight1.IsChecked == true)
            {
                FlightPlan TenAMChicago = new FlightPlan("Chicago", "154", "10:00 am", "10:46 am");
                string routeOne = TenAMChicago.concat();
                BookAFlight firstFlight = new BookAFlight(routeOne, "Marionette");
                firstFlight.Show();
                this.Close();
            }

            else if (this.Flight2.IsChecked == true)
            {
                FlightPlan TwelvePMChicago = new FlightPlan("Detroit", "155", "12:00 pm", "1:22 pm");
                string routeTwo = TwelvePMChicago.concat();
                FlightPlan2 flightTwo = new FlightPlan2();
                flightTwo.Show();
                this.Close();
            }

            else if (this.Flight3.IsChecked == true)
            {
                FlightPlan TwoPMOmaha = new FlightPlan("Omaha", "156", "2:00 pm", "6:33 pm");
                string routeThree = TwoPMOmaha.concat();
                FlightPlan3 flightThree = new FlightPlan3();
                flightThree.Show();
                this.Close();
            }

            else if (this.Flight3.IsChecked == true)
            {
                FlightPlan FiveFifftyNineSanDiego = new FlightPlan("San Diego", "157", "5:59 pm", "12:20 am");
                string routeFour = FiveFifftyNineSanDiego.concat();
                FlightPlan4 flightfour = new FlightPlan4();
                flightfour.Show();
                this.Close();
            }

            else
            {
                MessageBox.Show("No flight was selected");
            }

        }

    }
}
