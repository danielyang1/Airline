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
        List<Passenger> PassManifest = new List<Passenger>();
        public List<Passenger> FileReader()
        {
            string JSONstring = File.ReadAllText("../../manifest.json");
            PassManifest = JsonConvert.DeserializeObject<List<Passenger>>(JSONstring);
            if (PassManifest == null)
            {
                PassManifest = new List<Passenger>();
            }
            return PassManifest;
            //foreach (Passenger person in PlaneManifest)//dan doesnt think we need this part
            //{ 
            //    PlaneManifest.Add(person);
            //}
        }
        public void FileWriter(List<Passenger> anyList)
        {
            List<Passenger> readAgain = FileReader();
            anyList.AddRange(readAgain);
            string listOfPassengers = JsonConvert.SerializeObject(anyList, Formatting.Indented);
            File.WriteAllText("../../manifest.json", listOfPassengers);
        }
    }
}