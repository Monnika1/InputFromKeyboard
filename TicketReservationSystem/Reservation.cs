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
        public IDiscount Discount { get; set; }
        public UserType Type { get; set; }

        public Reservation(Show show, string customerName, IDiscount discount, UserType type)
        {
            Show = show;
            Tickets = new List<Ticket>();
            CustomerName = customerName;
            Discount = GetDiscountType(type);
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
        public IDiscount GetDiscountType(UserType type)
        {
            switch (type)
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
        public decimal GetDiscountedPrice(decimal price)
        {
            return Discount.ApplyDiscount(price);
        }

        public void RemoveTicket(Ticket ticket)
        {
            Tickets.Remove(ticket);
        }
        public bool RequestRefund() 
        {
            if (DateTime.Now<Show.Date.AddHours(-24))
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
    }
}
