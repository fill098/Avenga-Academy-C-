using System;
using System.Collections.Generic;
using System.Text;

namespace Class09.Cinema_System.Models
{
    public class Cinema
    {
        public string Name { get; set; }

        public int Halls { get; set; }

        public List<Movie> ListOfMovis { get; set; }


        public void MoviePlaying(Movie movie)
        {
            Console.WriteLine($"Watching: {movie.Title}");
        }
    }
}
