
using Class09.Cinema_System.Models;
using static System.Net.WebRequestMethods;
Console.OutputEncoding = System.Text.Encoding.UTF8;

#region TestData
/*
Practical Exercise – Cinema System
Requirements
Make a class Movie.

Movie must have:

Title
Genre
Rating
TicketPrice
Constructor must:

Set Title
Set Genre
Set Rating
Set TicketPrice = 5 * Rating
Rating must:

Be between 1 and 5
Throw exception if out of range
Handle other possible exceptions
Genre must be an enum with:

Comedy
Horror
Action
Drama
SciFi
Make a class Cinema.

Cinema must have:

Name
Halls
ListOfMovies
Cinema must have method MoviePlaying(movie) that prints:

Watching Movie.Title

We will provide 10 movies per cinema to put in the cinema movies list.

EXERCISE 1
Make a user interface that:

Lets the user choose a cinema.
Then choose:
All movies
By genre
If "All movies":

Show all movies
Let user choose a movie
Call MoviePlaying()
If "By genre":

Ask user for favorite genre
Show movies from that genre
Let user choose a movie
If user enters wrong input:

Throw an exception
Handle all exceptions using Try/Catch
*/

List<Movie> cinemaCityMovies = new List<Movie>()
{
    new Movie("The Grand Budapest Hotel", Genre.Comedy, 4),
    new Movie("Oppenheimer", Genre.Drama, 5),
    new Movie("Nope", Genre.Horror, 3),
    new Movie("Top Gun: Maverick", Genre.Action, 4),
    new Movie("The Menu", Genre.Horror, 4),
    new Movie("Arrival", Genre.SciFi, 5),
    new Movie("Knives Out", Genre.Comedy, 4),
    new Movie("Fury", Genre.Action, 4),
    new Movie("Tár", Genre.Drama, 4)
};


var bosnaFilmMovies = new List<Movie>
{
    new Movie("Elvis", Genre.Drama, 4),
    new Movie("Smile", Genre.Horror, 3),
    new Movie("Bullet Train", Genre.Action, 3),
    new Movie("Lightyear", Genre.SciFi, 3),
    new Movie("The Lost City", Genre.Comedy, 3),
    new Movie("Barbarian", Genre.Horror, 4),
    new Movie("Prey", Genre.Action, 5),
    new Movie("Vesper", Genre.SciFi, 4),
    new Movie("Glass Onion", Genre.Comedy, 4),
    new Movie("Aftersun", Genre.Drama, 5)
};

var starPlexMovies = new List<Movie>
{
    new Movie("M3GAN", Genre.Horror, 3),
    new Movie("Ant-Man and the Wasp: Quantumania", Genre.Action, 3),
    new Movie("65", Genre.SciFi, 2),
    new Movie("Cocaine Bear", Genre.Comedy, 3),
    new Movie("Creed III", Genre.Action, 4),
    new Movie("Scream VI", Genre.Horror, 4),
    new Movie("Air", Genre.Drama, 4),
    new Movie("Renfield", Genre.Comedy, 3),
    new Movie("Guardians of the Galaxy Vol. 3", Genre.SciFi, 5),
    new Movie("Past Lives", Genre.Drama, 5)
};


var cinemas = new List<Cinema>
{
    new Cinema { Name = "CinemaCity", Halls = 8, ListOfMovis = cinemaCityMovies },
    new Cinema { Name = "Bosna Film", Halls = 5, ListOfMovis = bosnaFilmMovies },
    new Cinema { Name = "StarPlex", Halls = 6, ListOfMovis = starPlexMovies }
};



#endregion

#region CinemaUI - Helper methods 
static void PrintHeader()
{
    Console.WriteLine("╔══════════════════════════════════════════════════════╗");
    Console.WriteLine("║                  ** CINEMA SYSTEM **                 ║");
    Console.WriteLine("╚══════════════════════════════════════════════════════╝");
}

static void PrintMenu(string title, List<string> options)
{
    Console.WriteLine($"\n┌──────────────────────────────────────────────────────┐");
    Console.WriteLine($"│  {title,-52}│");
    Console.WriteLine($"├──────────────────────────────────────────────────────┤");
    for (int i = 0; i < options.Count; i++)
    {
        Console.WriteLine($"│  {i + 1}) {options[i],-49}│");
    }
    Console.WriteLine($"└──────────────────────────────────────────────────────┘");
    Console.Write("  → Your choice: ");
}

static void PrintMovieList(string title, List<Movie> movies)
{
    Console.WriteLine($"\n┌─────────────────────────────-─────────────────────────────────┐");
    Console.WriteLine($"│  {title,-52}│");
    Console.WriteLine($"├────┬───────────────────────────────────┬──────────┬───────────┤");
    Console.WriteLine($"│ #  │ Title                             │ Genre    │ Price     │");
    Console.WriteLine($"├────┼───────────────────────────────────┼──────────┼───────────┤");
    for (int i = 0; i < movies.Count; i++)
    {
        var movie = movies[i];
        string truncatedTitle = movie.Title.Length > 33
            ? movie.Title.Substring(0, 30) + "..."
            : movie.Title;
        Console.WriteLine($"│ {i + 1,-2} │ {truncatedTitle,-33} │ {movie.Genre,-8} │ ${movie.TicketPrice,-9}│");
    }
    Console.WriteLine($"└────┴───────────────────────────────────┴──────────┴───────────┘");
    Console.Write("  → Choose a movie: ");
}

static void PrintNowPlaying(Movie movie)
{
    Console.WriteLine($"\n╔══════════════════════════════════════════════════════╗");
    Console.WriteLine($"║  Now Playing: {movie.Title,-39}║");
    Console.WriteLine($"║  Genre:       {movie.Genre,-39}║");
    Console.WriteLine($"║  Price:       ${movie.TicketPrice,-38}║");
    Console.WriteLine($"╚══════════════════════════════════════════════════════╝");
}

static void PrintError(string message)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine($"\n  !! {message}");
    Console.ResetColor();
}

static void PrintSuccess(string message)
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine($"\n  >> {message}");
    Console.ResetColor();
}







#endregion

#region CinemaUI Consol App

while (true)
{
    try
    {
        Console.Clear();
        PrintHeader();

        
        PrintMenu("Choose a Cinema", cinemas.Select(c => c.Name).ToList());
        int cinemaInput = int.Parse(Console.ReadLine());
        if (cinemaInput < 1 || cinemaInput > cinemas.Count)
            throw new Exception("Invalid cinema selection!");
        Cinema currentCinema = cinemas[cinemaInput - 1];

       
        PrintMenu($"{currentCinema.Name} - Browse Movies", new List<string> { "All Movies", "By Genre" });
        int moviesInput = int.Parse(Console.ReadLine());

        if (moviesInput == 1)
        {
           
            PrintMovieList("All Movies", currentCinema.ListOfMovis);
            int movieSelection = int.Parse(Console.ReadLine());
            Movie selectedMovie = currentCinema.ListOfMovis[movieSelection - 1];
            currentCinema.MoviePlaying(selectedMovie);
            PrintNowPlaying(selectedMovie);
        }
        else if (moviesInput == 2)
        {
            
            PrintMenu("Choose a Genre", new List<string> { "Comedy", "Horror", "Action", "Drama", "SciFi" });
            int genreInput = int.Parse(Console.ReadLine());
            if (genreInput < 1 || genreInput > 5)
                throw new Exception("Invalid genre selection!");
            Genre currentGenre = (Genre)genreInput;
            List<Movie> filteredMovies = currentCinema.ListOfMovis.Where(m => m.Genre == currentGenre).ToList();
            PrintMovieList($"{currentGenre} Movies", filteredMovies);
            int movieSelection = int.Parse(Console.ReadLine());
            Movie selectedMovie = filteredMovies[movieSelection - 1];
            currentCinema.MoviePlaying(selectedMovie);
            PrintNowPlaying(selectedMovie);
        }
        else
        {
            throw new Exception("Invalid menu selection!");
        }

        
        PrintSuccess("Enjoy your movie!");
        Console.Write("\n  → Watch another movie? (y/n): ");
        if (Console.ReadLine().ToLower() == "n") break;
    }
    catch (FormatException)
    {
        PrintError("Please enter a valid number!");
        Console.ReadKey();
    }
    catch (ArgumentOutOfRangeException)
    {
        PrintError("That movie does not exist!");
        Console.ReadKey();
    }
    catch (Exception ex)
    {
        PrintError(ex.Message);
        Console.ReadKey();
    }
}
#endregion
