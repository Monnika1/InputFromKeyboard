using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketReservationSystem
{
    internal class StudentDiscount : IDiscount
    {
        public decimal ApplyDiscount(decimal price)
        {
            decimal discountRate = 0.20m;
            return price - (price * discountRate);
        }
    }
}
