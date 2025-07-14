using System.Globalization;

namespace TicketReservationSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("------Welcome to the Ticket Reservation System------!");

            var user = new User("Ioana Petrova", "ioana@stoyaanovaaaa.bg", "0999253442");

            var seats = new List<Seat>
            {
                new Seat(1,1),
                new Seat(1,2),
                new Seat(1,3)
            };
            var show = new Show("The sleeping beauty", new DateTime(2025, 8, 4), 145, seats);

            var requestedSeats = new List<SeatRequest> { new SeatRequest(1, 1), new SeatRequest(1, 2) };

            IPayment payment = new PayPal();

            var reservationSystem = new ReservationSystem();
            var reservation = reservationSystem.CreateReservation(user, show, requestedSeats, Ticket.TicketType.VIP, Reservation.UserType.Student, payment);


            var user2 = new User("Kristiyana Cholakova", "krisi@ch7777.bg", "0715223456");
            var requestedSeats2 = new List<SeatRequest> { new SeatRequest(1, 3) };
            var reservation2 = reservationSystem.CreateReservation(user2, show, requestedSeats2, Ticket.TicketType.Standard, Reservation.UserType.Adult, payment);

            if (reservation != null)
            {
                Console.WriteLine($"Reservation for {reservation2.CustomerName}, show:{reservation2.Show.Name}, Date: {reservation2.Show.Date}");
                Console.WriteLine($"Reservation for {reservation.CustomerName} created successfully!");
                Console.WriteLine($"Show:{reservation.Show.Name}, Date:{reservation.Show.Date}");
                Console.WriteLine($"Reserved seats: ");
                foreach (var ticket in reservation.Tickets)
                {
                    Console.WriteLine($"-Row{ticket.Seat.Row}, Seat{ticket.Seat.Number}, Ticket type:{ticket.GetType().Name}, Price:{ticket.Price}");
                }
            }
               Reservation reservation1 = new Reservation(show, user.Name, Reservation.UserType.Adult);
            reservation1.AddTicket(new VIP(150, new Seat(2, 3)));
    
            Console.WriteLine($"Reservation for {reservation1.CustomerName} created successfully!");
            Console.WriteLine($"Show: {reservation1.Show.Name}, Date: {reservation1.Show.Date}");



            Console.WriteLine("-----Thank you for using the Ticket Reservation System!<3-----");
        }
    }
}
