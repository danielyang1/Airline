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
    /// Interaction logic for BookAFlight.xaml
    /// </summary>
    public partial class BookAFlight : Window
    {
        private string PlaneNames;
        private string FlightInfo;
        public Plane Marionette;
        public List<Seat> Airplane320;
        public Manifest Main;
        public List<Passenger> PassManifest;
        public BookAFlight(string flightInfo, string name)
        {
            InitializeComponent();
            Loaded += BookAFlight_Loaded;
            this.FlightInfo = flightInfo;
            this.PlaneNames = name;
            this.Airplane320 = new List<Seat>();
        }

        private void BookAFlight_Loaded(object sender, RoutedEventArgs e)
        {
            Manifest Main = new Manifest();
            this.Main = new Manifest();
            Plane Marionette = new Plane(true, 3000);
            this.Marionette = new Plane(true, 3000);

            List<Seat>Airplane320 = new List<Seat>();
            NumOfSeats.Text = Marionette.Airplane320.Count.ToString();
            PlaneName.Text = this.PlaneNames;
            FlightInformation.Text = this.FlightInfo;

            foreach (Seat chair in Marionette.Airplane320)
            {
                ListOfAvailableSeats.Items.Add(chair);
    
            }
            
        }

        private void ListOfAvailableSeats_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            FileRead readWrite = new FileRead();
            List<Passenger> PassManifest = new List<Passenger>();
            readWrite.FileReader();
            Marionette.PurchaseSeat(Airplane320);
            string seatID = Marionette.assignToPerson();
            Passenger person = new Passenger(PassengerName.Text, Age.Text, Email.Text, seatID);
            Main.PassManifest.Add(person);
            readWrite.FileWriter(PassManifest);

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
