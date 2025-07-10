using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketReservationSystem
{
    internal class PayPal : IPayment
    {
        public void Pay (decimal amount) =>
        
            Console.WriteLine($"Paid {amount} using PayPal.");
        
    }
}
