using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketReservationSystem
{
    internal class EarlyBirdDiscount : IDiscount
    {
        public decimal ApplyDiscount(decimal price)
        {
            return price * 0.90m;
        }
    }
}
