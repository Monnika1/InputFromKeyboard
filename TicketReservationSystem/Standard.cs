using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketReservationSystem
{
    internal class Standard : Ticket
    {
        public Standard(decimal price, Seat seat) : base(price, seat)
        {

        }
    }
}
