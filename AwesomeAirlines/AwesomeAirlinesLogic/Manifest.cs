using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AwesomeAirlinesLogic
{
    public class Manifest : IEnumerable
    {
        public List<Passenger> PassManifest;

        public Manifest(Passenger passenger)
        {
            PassManifest = new List<Passenger>();
            PassManifest.Add(passenger);
        }
        public void AddPassengerToManifest(Passenger pass)
        {
            PassManifest.Add(pass);
        }
        public IEnumerator GetEnumerator()
        {
            foreach (Passenger pass in PassManifest)
            {
                yield return pass;
            }
        }
    }
}