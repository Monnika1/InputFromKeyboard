using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketReservationSystem
{
    internal class VIP : Ticket
    {
        public VIP(decimal price, Seat seat) : base(price + 50, seat)
        {
          
        }
        public string GetVIPBenefits()
        {
            return "Access to VIP lounge, complimentary drinks, and priority seating.";
        } 
    }
}
