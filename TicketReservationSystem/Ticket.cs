using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketReservationSystem
{
    internal abstract class Ticket
    {
        public decimal Price { get; set; }
        public Seat Seat { get; set; }

        public enum TicketType
        {
            Standart, 
            VIP
        }

        public Ticket(decimal price, Seat seat)
        {
            Price = price;
            Seat = seat;
        }
    }
}
