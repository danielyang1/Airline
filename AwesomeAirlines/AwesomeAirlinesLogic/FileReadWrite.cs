using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;
using System.Web.Script.Serialization;

namespace AwesomeAirlinesLogic
{
    public class FileRead
    {
        public int removeSeat = 0;
        public List<Passenger> PassManifest;
        public void FileReader()
        {
            string JSONstring = File.ReadAllText("../../manifest.json");
            PassManifest = JsonConvert.DeserializeObject<List<Passenger>>(JSONstring);
            if (PassManifest == null)
            {
                this.PassManifest = new List<Passenger>();
            }

        }

        public void seatsToSubtract(List<Seat> chair)
        {
            foreach (Passenger pass in PassManifest)
            {
                chair.RemoveAt(removeSeat);
            }
        }

        public void AddPassengerToManifest(Passenger pass)
        {
            PassManifest.Add(pass);
        }


        public void FileWriter(Passenger pass)
        {
            List<Passenger> readAgain = this.PassManifest;
            readAgain.Add(pass);
            string listOfPassengers = JsonConvert.SerializeObject(readAgain, Formatting.Indented);
            File.WriteAllText("../../manifest.json", listOfPassengers);

        }
    }
}