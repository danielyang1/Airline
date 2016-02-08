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
    /// Interaction logic for FlightPlan3.xaml
    /// </summary>
    public partial class FlightPlan3 : Window
    {
        private string PlaneNames;
        private string FlightInfo;
        public Plane Marionette;
        FileRead readWrite;
        public Manifest Main;
        public List<Passenger> PassManifest;
        public FlightPlan3(string flightInfo, string name)
        {
            InitializeComponent();
            this.FlightInfo = flightInfo;
            this.PlaneNames = name;
        }

        private void ListOfAvailableSeats_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void BookAFlight_Loaded(object sender, RoutedEventArgs e)
        {
            Manifest Main = new Manifest();

            Marionette = new Plane(true, 3000);


            FileRead readWrite = new FileRead();

            readWrite.FileReader();
            int seatsToSubtract = readWrite.PassManifest.Count();
            readWrite.seatsToSubtract(Marionette.Airplane320);

            NumOfSeats.Text = Marionette.Airplane320.Count.ToString();
            PlaneName.Text = this.PlaneNames;
            FlightInformation.Text = this.FlightInfo;

            foreach (Seat chair in Marionette.Airplane320)
            {
                ListOfAvailableSeats.Items.Add(chair);

            }

        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            Manifest Main = new Manifest();
            this.Main = new Manifest();
            Marionette = new Plane(true, 3000);
            this.Marionette = new Plane(true, 3000);

            FileRead readWrite = new FileRead();
            this.readWrite = new FileRead();
            readWrite.FileReader();
            int seatsToSubtract = readWrite.PassManifest.Count();
            readWrite.seatsToSubtract(Marionette.Airplane320);

            NumOfSeats.Text = Marionette.Airplane320.Count.ToString();
            PlaneName.Text = this.PlaneNames;
            FlightInformation.Text = this.FlightInfo;

            foreach (Seat chair in Marionette.Airplane320)
            {
                ListOfAvailableSeats.Items.Add(chair);

            }


            Marionette.PurchaseSeat(Marionette.Airplane320);
            string seatID = Marionette.assignToPerson();
            Passenger person = new Passenger(PassengerName.Text, Age.Text, Email.Text, seatID);
            Main.AddPassengerToManifest(person);
            readWrite.FileWriter(person);

            PassengerName.Text = "";
            Age.Text = "";
            Email.Text = "";

            this.Close();
            this.Show();
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
