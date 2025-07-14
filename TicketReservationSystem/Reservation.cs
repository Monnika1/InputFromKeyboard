using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static TicketReservationSystem.User;

namespace TicketReservationSystem
{
    internal class Reservation
    {
        public List<Ticket> Tickets { get;}
        public Show Show { get; set; }
        public string CustomerName { get; set; }
        public UserType Type { get; set; }

        public Reservation(Show show, string customerName, UserType type)
        {
            Show = show;
            Tickets = new List<Ticket>();
            CustomerName = customerName;
            Type = type;
        }
        public void AddTicket(Ticket ticket)
        {
            Tickets.Add(ticket);
        }
        public enum UserType
        {
            Child,
            Student,
            Adult
        }


        public decimal GetDiscountedPrice()
        {
            List<IDiscount> allDiscounts = GetAllDiscounts();
            decimal totalPrice = Tickets.Sum(ticket => ticket.Price);
            foreach (var discount in allDiscounts)
            {
                totalPrice = discount.ApplyDiscount(totalPrice);
            }
            return totalPrice;
        }


        public void RemoveTicket(Ticket ticket)
        {
            Tickets.Remove(ticket);
        }

        public bool RequestRefund()
        {
            if (DateTime.Now < Show.Date.AddHours(-24))
            {
                Console.WriteLine("Refund approved.");
                return true;
            }
            else
            {
                Console.WriteLine("Refund denied. You can only request a refund 24 hours before the show.");
                return false;
            }
        }

        private IDiscount GetUserDiscountType()
        {
            switch (Type)
            {
                case UserType.Child:
                    return new EarlyBirdDiscount();
                case UserType.Student:
                    return new StudentDiscount();
                case UserType.Adult:
                    return new NoDiscount();
                default:
                    return new NoDiscount();
            }
        }

        private List<IDiscount> GetAllDiscounts()
        {
            List<IDiscount> allDiscounts = new List<IDiscount>();

            decimal totalPrice = Tickets.Sum(ticket => ticket.Price);

            // na baza na total price opredelqme dali shte dobavim PriceDiscount
            if (totalPrice>=100)
            {
                allDiscounts.Add(new PriceDiscount());
            }
            // gledame user tipa
            IDiscount userDiscount = GetUserDiscountType();

            allDiscounts.Add(userDiscount);
           
            return allDiscounts;
        }


    }
}
