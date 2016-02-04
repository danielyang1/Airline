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
    /// Interaction logic for FlightPlan2.xaml
    /// </summary>
    public partial class FlightPlan2 : Window
    {
        private string PlaneNames;
        private string FlightInfo;

        public FlightPlan2(string flightInfo, string name)
        {
            InitializeComponent();
            Loaded += BookAFlight_Loaded;
            this.FlightInfo = flightInfo;
            this.PlaneNames = name;
        }

        private void BookAFlight_Loaded(object sender, RoutedEventArgs e)
        {
            Plane Lushen = new Plane(true, 3300);
            List<Seat> Airplane320 = new List<Seat>();
            NumOfSeats.Text = Lushen.Airplane320.Count.ToString();
            PlaneName.Text = this.PlaneNames;
            FlightInformation.Text = this.FlightInfo;

            foreach (Seat chair in Lushen.Airplane320)
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
    }
}
