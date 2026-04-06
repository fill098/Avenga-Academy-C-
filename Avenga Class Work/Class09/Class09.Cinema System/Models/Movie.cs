using System;
using System.Collections.Generic;
using System.Text;

namespace Class09.Cinema_System.Models
{
    public class Movie
    {
        public string Title { get; set; }

        public Genre Genre { get; set; }

        public double Rating { get; set; }

        public double TicketPrice { get; set; }

        public Movie(string title, Genre genre, double rating)
        {

            Title = title;
            Genre = genre;
            SetRating(rating);
            TicketPrice = 5 * rating;
                
        }



        public void SetRating(double rating)
        {
            try
            {
                if (rating < 1 || rating > 5)
                    throw new ArgumentOutOfRangeException(nameof(rating), "Rating must be between 1 and 5.");

                Rating = rating;
                TicketPrice = 5 * Rating;
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine($"[Rating Error] {ex.Message}");
                throw;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"[Unexpected Rating Error] {ex.Message}");
                throw;
            }
        }


    }
    
}
