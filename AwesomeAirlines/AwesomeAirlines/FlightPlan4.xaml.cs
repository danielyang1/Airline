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
    /// Interaction logic for FlightPlan4.xaml
    /// </summary>
    public partial class FlightPlan4 : Window
    {
        private string PlaneNames;
        private string FlightInfo;

        public FlightPlan4(string flightInfo, string name)
        {
            InitializeComponent();
            Loaded += BookAFlight_Loaded;
            this.FlightInfo = flightInfo;
            this.PlaneNames = name;
        }

        private void BookAFlight_Loaded(object sender, RoutedEventArgs e)
        {
            Plane Veromos = new Plane(true, 3500);
            List<Seat> Airplane320 = new List<Seat>();
            NumOfSeats.Text = Veromos.Airplane320.Count.ToString();
            PlaneName.Text = this.PlaneNames;
            FlightInformation.Text = this.FlightInfo;

            foreach (Seat chair in Veromos.Airplane320)
            {
                ListOfAvailableSeats.Items.Add(chair);

            }
        }

        private void ListOfAvailableSeats_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ClearAllText_Click(object sender, RoutedEventArgs e)
        {
            PassengerName.Text = "";
            Age.Text = "";
            Email.Text = "";
        }

        private void GoBackToMainMenu_Click(object sender, RoutedEventArgs e)
        {
            MainWindow goBack = new MainWindow();
            goBack.Show();
            this.Close();
        }
    }
}
