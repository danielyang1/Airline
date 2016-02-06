using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AwesomeAirlinesLogic
{
    public class Plane
    {
        public List<Seat> Airplane320;

        public Seat seatToRemove;

        public bool maxCapacity = false;

        public int MaxMilesPerTrip;

        public bool maintenanceStatusGood = true;

        public bool maintenanceStatusBad;

        

        public Plane(bool mstatus, int range)
        {
            this.maintenanceStatusGood = mstatus;
            this.MaxMilesPerTrip = range;

            Airplane320 = new List<Seat>();
            foreach (RowNumber row in Enum.GetValues(typeof(RowNumber)))
            {
                foreach (SeatNumber seat in Enum.GetValues(typeof(SeatNumber)))
                {
                    Seat anySeat = new Seat(row, seat);
                    Airplane320.Add(anySeat);
                }
            }
        }
        public void checkMaxCapacity()
        {
            if (Airplane320.Count <= 0)
            {
                this.maxCapacity = true;
            }
        }

        public void PurchaseSeat(List<Seat> Airplane320)
        {
            int removeSeat = 1;
            this.seatToRemove = Airplane320[removeSeat];
            Airplane320.RemoveAt(removeSeat);
        }
        public string assignToPerson()
        {
            string seatString = this.seatToRemove.ToString();
            return seatString;
        }

        
        public void maintenanceStatus()
        {
            if (maintenanceStatusGood == false)
            {
                this.maintenanceStatusBad = true;
            }
        }

        public string fullAirplane()
        {
            if (this.maxCapacity == true)
            {
                string full = "There is no more seats available on this flight";
                return full;
            }
            else
            {
                string full = "There are seats available";
                    return full;
            }
        }
    }
}
