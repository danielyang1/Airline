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
        List<Passenger> PassManifest;
        public void FileReader()
        {
            string JSONstring = File.ReadAllText("../../manifest.json");
            PassManifest = JsonConvert.DeserializeObject<List<Passenger>>(JSONstring);
            if (PassManifest == null)
            {
                this.PassManifest = new List<Passenger>();
            }

        }

        public void FileWriter(List<Passenger> anyList)
        {
            List<Passenger> readAgain = this.PassManifest;
            anyList.AddRange(readAgain);
            string listOfPassengers = JsonConvert.SerializeObject(anyList, Formatting.Indented);
            File.WriteAllText("../../manifest.json", listOfPassengers);

        }
    }
}