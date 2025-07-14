using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketReservationSystem
{
    internal interface IDiscount
    {
        /// <summary>
        /// </summary>
        /// <param name="price"></param>
        /// <returns>the price with the discount</returns>
        decimal ApplyDiscount(decimal price);
        string GetDiscountType()
        {
            return this.GetType().Name;
        }
    }
}
