using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketReservationSystem
{
    internal interface IDiscount
    {
        decimal ApplyDiscount(decimal price);
        string GetDiscountType()
        {
            return this.GetType().Name;
        }
    }
}
