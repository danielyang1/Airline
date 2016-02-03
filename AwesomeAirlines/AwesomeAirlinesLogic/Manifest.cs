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
        public List<Seat> SeatsOnPlane;
        public List<Passenger> PassManifest;
        Plane plane;

        public Manifest(Passenger passenger)
        {
            PassManifest = new List<Passenger>();
            PassManifest.Add(passenger);
        }
        public void AddPassengerToManifest(Passenger pass)
        {
            PassManifest.Add(pass);
        }
        public List<Seat> ListLessPurchase()
        {
            int removeSeat = 0;
            SeatsOnPlane.RemoveAt(removeSeat);
            return SeatsOnPlane;
        }

        public IEnumerator GetEnumerator()
        {
            foreach (Passenger x in PassManifest)
            {
                yield return x;
            }
        }
    }
}