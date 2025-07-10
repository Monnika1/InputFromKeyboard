using System.Globalization;

namespace TicketReservationSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("------Welcome to the Ticket Reservation System------!");

            var user = new User("Ivan Petrov", "iv@an", "0944437656");
            var seats = new List<Seat>
            {
                new Seat(1,1),
                new Seat(1,2),
                new Seat(1,3)
            };
            var show = new Show("Inception", new DateTime(2025, 7, 15), 120, seats);
            var requestedSeats = new List<SeatRequest> { new SeatRequest(1, 1), new SeatRequest(1, 2) };

            IPayment payment = new PayPal();
            var reservationSystem = new ReservationSystem();
            var reservation = reservationSystem.CreateReservation(user, show, requestedSeats, Ticket.TicketType.VIP, Reservation.UserType.Student, payment);


            if (reservation != null)
            {
                Console.WriteLine($"Reservation for {reservation.CustomerName} created successfully!");
                Console.WriteLine($"Show:{reservation.Show.Name}, Date:{reservation.Show.Date}");
                Console.WriteLine($"Reserved seats: ");
                foreach (var ticket in reservation.Tickets)
                {
                    Console.WriteLine($"-Row{ticket.Seat.Row}, Seat{ticket.Seat.Number}, Ticket type:{ticket.GetType().Name}, Price:{ticket.Price}");
                }
            }

            //DateTimeOffset dateTime = default;
            //if (dateTime == default)
            //{
            //    Console.WriteLine("DateTimeOffset is not initialized.");
            //}
            //else
            //{
            //    Console.WriteLine("DateTimeOffset is initialized.");
            //}

            //DateTimeOffset dateTimeOffset = DateTimeOffset.UtcNow;
            //Console.WriteLine(dateTimeOffset.ToString("o"));

            //Console.WriteLine("Please enter a show to reserve your ticket:");
            //Show show = new Show("Inception", new DateTime(2015, 3, 4), 100);
            //Console.WriteLine($"Show: {show.Name}, Date: {show.Date}, Ticket Price: {show.TicketPrice}, Available Seats: {show.AvailableSeats}");

            //Console.WriteLine("Please enter your name:");
            //User user1 = new User(name: "Ivan Petrov", email:"petrov@abv.bg", phoneNumber: "0887655409");
            ///*User user2 = new User(name: "Maria Ivanova", email:"sfjfns", phoneNumber: "0888888888", type: User.UserType.Child);
            //User user3 = new User(name: "Georgi Georgiev", email:"sfjfns", phoneNumber: "0888888888", type: User.UserType.Adult);*/
            //Console.WriteLine($"User 1: {user1.Name}");
            //Reservation reservation = new Reservation(show, user1.Name, new NoDiscount(), Reservation.UserType.Adult);
            //Console.WriteLine($"Reservation for {reservation.CustomerName} created for show: {reservation.Show.Name}");
            //Show show1 = new Show("Avatar", new DateTime(2023, 10, 15), 150);
            //Console.WriteLine($"Show: {show1.Name}, Date: {show1.Date}, Ticket Price: {show1.TicketPrice}");


            //Seat seat6 = new Seat(1, 5);
            //Console.WriteLine($"Seat Number: {seat6.Number}, Row: {seat6.Row}, Is Taken: {seat6.IsTaken}");

            //Ticket vip = new VIP(5);

            //Reservation reservation1 = new Reservation(show1, user1.Name, new NoDiscount(), Reservation.UserType.Adult);

            //Console.WriteLine($"Ticket added for {reservation1.CustomerName} in show: {reservation1.Show.Name}, Ticket Type: {vip.GetType().Name}");

            //IPayment paymentMethod = new PayPal();
            //Show show2 = new Show("The Matrix", new DateTime(2023, 11, 20), 120);

            //Console.WriteLine($"Show: {show2.Name}, Date: {show2.Date}, Ticket Price: {show2.TicketPrice}, {show2.AvailableSeats}");


    

            decimal originalPrice = 200.00m;

            IDiscount discount = new StudentDiscount();
            decimal discountedPrice = discount.ApplyDiscount(originalPrice);
            Console.WriteLine($"Original Price: {originalPrice}, Discounted Price: {discountedPrice}");


            Console.WriteLine("-----Thank you for using the Ticket Reservation System!<3-----");
        }
    }
}
