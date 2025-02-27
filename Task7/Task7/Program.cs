using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task7
{
    public class MovieTicket
    {
        public string MovieName;
        public int SeatNumber;
        private bool IsBooked;

        public MovieTicket(string movieName, int seatNumber, bool isBooked)
        {
            MovieName = movieName;
            SeatNumber = seatNumber;
            IsBooked = false;
        }
        public void BookTicket()
        {
            if (!IsBooked)
            {
                IsBooked = true;
                Console.WriteLine($"Seat {SeatNumber} Booking is Done: ");
            }
            else
            {
                Console.WriteLine($"Seat {SeatNumber} is already Booked: ");
            }   
        }
        public void Displeyseet()
        {
            Console.WriteLine($"Seat {SeatNumber} is Booked ? -> {IsBooked} \n");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            MovieTicket[] movieTickets = new MovieTicket[5];
            for (int i = 0; i < 5; i++)
            {
                movieTickets[i] = new MovieTicket("The Godfather", i + 1, false);
            }
            Console.WriteLine("This is a Avalible Seats before Booking:\n ");
            foreach (MovieTicket movie in movieTickets)
            {
                movie.Displeyseet();
            }
              bool chose = true;

            while (chose)
            {
                Console.WriteLine("Please Enther the Seat Number you want to booked ( is 1 to 5 ) End 9 for Exit:\n ");
                int seatnumber = int.Parse(Console.ReadLine());
                if ((seatnumber < 1 || seatnumber > 5) && seatnumber != 9)
                {
                    Console.WriteLine("You are imput Invalead Seat number:");
                }
                else if (seatnumber == 9)
                {
                    chose = false;
                }
                else
                {
                    movieTickets[seatnumber - 1].BookTicket();
                    Console.WriteLine("Updating Seat avalible\n");
                    foreach (MovieTicket movie in movieTickets)
                    {
                        movie.Displeyseet();
                    }
                }
                
            }
        }
    }
}
