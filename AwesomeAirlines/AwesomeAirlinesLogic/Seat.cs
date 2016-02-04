using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AwesomeAirlinesLogic
{
    public enum SeatNumber
    {
        A = 1,
        B = 2,
        C = 3,
        D = 4,
        E = 5,
        F = 6
    }

    public enum RowNumber
    {
        One = 1,
        Two = 2,
        Three = 3,
        Four = 4,
        Five = 5, 
        Six = 6,
        Seven = 7,
        Eight = 8,
        Nine = 9,
        Ten = 10
    }

    public class Seat
    {
        public SeatNumber SeatNum;

        public RowNumber RowNum;

        public string Name;

        public double Price;

        public Seat(RowNumber row, SeatNumber seat)
        {
            this.SeatNum = seat;
            this.RowNum = row;
        }
        public override string ToString()
        {
            return RowNum + "-" + SeatNum;
        }
    }
}
