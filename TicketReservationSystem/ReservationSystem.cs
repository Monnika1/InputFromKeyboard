using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketReservationSystem
{
    internal class ReservationSystem
    {
        public Reservation CreateReservation(

            User user,
                Show show,
                List<SeatRequest> requestedSeats,
                Ticket.TicketType ticketType,
                Reservation.UserType userType,
                IPayment paymentMethod)
        {

            if (!show.AreSeatsAvailable(requestedSeats))
            {
                Console.WriteLine("Some of the requested seats are already taken :( ");
                return null;
            }

            var reservation = new Reservation(show, user.Name, userType);
            foreach (var request in requestedSeats)
            {
                Seat seat = show.Seats.FirstOrDefault(s => s.Row == request.Row && s.Number == request.Number);
                if (seat != null && !seat.IsTaken)
                {
                    seat.TakeSeat();
                    Ticket ticket;
                    if (ticketType == Ticket.TicketType.VIP)
                    {
                        ticket = new VIP(show.TicketPrice + 50, seat);
                    }
                    else
                    {
                        ticket = new Standard(show.TicketPrice, seat);
                    }

                    reservation.AddTicket(ticket);
                }
            }
    
       
            decimal totalPrice = reservation.GetDiscountedPrice();

            paymentMethod.Pay(totalPrice);


            // Apply all discounts

            
            Console.WriteLine($"Payment of {totalPrice} was successful using {paymentMethod.GetType().Name}.");

            return reservation;
        }
    }
}
