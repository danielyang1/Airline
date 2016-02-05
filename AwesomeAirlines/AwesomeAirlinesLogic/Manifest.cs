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
        public List<Seat> SeatsOccupied;
        public List<Passenger> PassManifest;
        Seat seatToRemove;

        public Manifest(Passenger passenger)
        {
            PassManifest = new List<Passenger>();
            PassManifest.Add(passenger);
        }
        public void AddPassengerToManifest(Passenger pass)
        {
            PassManifest.Add(pass);
        }
        public void ListLessPurchase(List<Seat> Airplane320)
        {
            int removeSeat = 0;
            this.seatToRemove = Airplane320[removeSeat];
            Airplane320.RemoveAt(removeSeat);
        }
        public void ListOfOccupiedSeats()
        {
            if (SeatsOccupied == null)
            {
                SeatsOccupied = new List<Seat>();
            }
            SeatsOccupied.Add(this.seatToRemove);
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