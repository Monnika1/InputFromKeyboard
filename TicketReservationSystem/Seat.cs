using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketReservationSystem
{
    internal class Seat
    {
        public int Row { get; private set; }
        public int Number { get; private set; }
        public bool IsTaken { get; private set; }

        public Seat(int row, int number)
        {
            Row = row;
            Number = number;
        }

        public void TakeSeat()
        {
            IsTaken = true;
        }
    }

    internal class SeatRequest
    {
        public SeatRequest(int row, int number)
        {
            Row = row;
            Number = number;
        }

        public int Row { get; private set; }
        public int Number { get; private set; }
    }
}
