using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace TicketReservationSystem
{
    internal class Show
    {
        public string Name { get; private set; }
        public DateTime Date { get; private set; }
        public int TicketPrice { get; private set; }

        public int AvailableSeats => GetAvailableSeatsCount();

       public  List<Seat> Seats { get;private set; }

        public Show(string name, DateTime date, int ticketPrice, List<Seat> seats)
        {
            Name = name;
            Date = date;
            TicketPrice = ticketPrice;
            Seats = seats;
        }

        public void Reserve(int row, int number)
        {
            var aaa= Seats.Where(x => x.Row.Equals(row) && x.Number.Equals(number)).FirstOrDefault();
            if(aaa is not null)
            {
                aaa.TakeSeat();
            }
        }
        public int GetAvailableSeatsCount()
        {

            if (Seats == null || Seats.Count == 0)
            {
                Console.WriteLine("No seats available for this show.");
                return 0;
            }

            int availableSeats = Seats.Count(seat => !seat.IsTaken);

            Console.WriteLine($"Available seats for {Name}: {availableSeats}");

            return availableSeats;
        }

        public bool AreSeatsAvailable(List<SeatRequest> seatsToReserve)
        {
            foreach (SeatRequest seat in seatsToReserve)
            {
                Seat found = Seats.Where(x => x.Row.Equals(seat.Row) && x.Number.Equals(seat.Number)).FirstOrDefault();
                if (found is null || (found is not null && found.IsTaken))
                    return false;
            }
            return true;
        }
    }
}
