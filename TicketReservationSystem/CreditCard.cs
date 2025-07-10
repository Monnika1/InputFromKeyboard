using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketReservationSystem
{
    internal class CreditCard : IPayment
    {
        public void Pay(decimal amount) =>

            Console.WriteLine($"Processing credit card payment of {amount}");
    }
}
