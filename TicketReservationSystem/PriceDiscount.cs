using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketReservationSystem
{
    internal class PriceDiscount : IDiscount
    {
        public decimal ApplyDiscount(decimal price)
        {
            if (price>=100)
            {
                return price - (price * 0.10m);
            }
            else
            {
                return price;
            }
        } 
    }
}
