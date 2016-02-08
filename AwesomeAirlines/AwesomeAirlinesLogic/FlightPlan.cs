using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AwesomeAirlinesLogic
{
    public enum CitiesToTravel
    {
        Chicago = 92,
        Detroit = 381,
        Omaha = 513,
        San_Diego = 2119
    }
    public class FlightPlan
    {
        public string Origin = "Milwaukee";

        public string TimeOfDeparture;

        public string FlightNumber;

        public string Destination;

        public string TimeOfTravel;

        public FlightPlan(string destination, string flightNumber, string timeOfDeparture, string timeOfTravel)
        {
            this.Destination = destination;
            this.FlightNumber = flightNumber;
            this.TimeOfDeparture = timeOfDeparture;
            this.TimeOfTravel = timeOfTravel;
        }

        public string concat()
        {
            string flightData = "Flight: " + FlightNumber + " From " + Origin + " To " + Destination + " at " + TimeOfDeparture + ". " + "ETA: " + TimeOfTravel;
            return flightData;
        }
    }
}
