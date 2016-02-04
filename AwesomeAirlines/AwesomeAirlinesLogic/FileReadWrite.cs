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
        List<Passenger> PlaneManifest;
        public void FileReader()
        {
            // DEserialize
            string JSONstring = File.ReadAllText("../../manifest.json");
            List<Passenger> PlaneManifest = JsonConvert.DeserializeObject<List<Passenger>>(JSONstring);
            if (PlaneManifest == null)
                PlaneManifest = new List<Passenger>();
        }
        public void FileWriter()
        {
            // SErializing
            string listOfPassengers = JsonConvert.SerializeObject(PlaneManifest, Formatting.Indented);
            File.WriteAllText("../../manifest.json", listOfPassengers);

        }
    }
}
