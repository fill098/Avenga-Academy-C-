// ─── Movies ───────────────────────────────────────────────
using Class09.Cinema_System.Models;

Movie movie1 = new Movie("The Grand Illusion", Genre.Comedy, 4);
Movie movie2 = new Movie("Midnight Shadows", Genre.Horror, 5);
Movie movie3 = new Movie("Thunder Ridge", Genre.Action, 3);
Movie movie4 = new Movie("Hearts Apart", Genre.Drama, 4);
Movie movie5 = new Movie("Galactic Drift", Genre.SciFi, 5);
Movie movie6 = new Movie("Laugh Factory", Genre.Comedy, 2);
Movie movie7 = new Movie("The Haunting", Genre.Horror, 3);
Movie movie8 = new Movie("Steel Fist", Genre.Action, 4);
Movie movie9 = new Movie("Quiet Storm", Genre.Drama, 5);
Movie movie10 = new Movie("Nebula Code", Genre.SciFi, 3);

// ─── Cinemas ──────────────────────────────────────────────
Cinema cinema1 = new Cinema
{
    Name = "CineMax Downtown",
    Halls = 6,
    ListOfMovis = new List<Movie> { movie1, movie2, movie3, movie4, movie5, movie6, movie7, movie8, movie9, movie10 }
};

Cinema cinema2 = new Cinema
{
    Name = "Starlight Plaza",
    Halls = 4,
    ListOfMovis = new List<Movie> { movie1, movie2, movie3, movie4, movie5, movie6, movie7, movie8, movie9, movie10 }
};

Cinema cinema3 = new Cinema
{
    Name = "Metro Grand",
    Halls = 8,
    ListOfMovis = new List<Movie> { movie1, movie2, movie3, movie4, movie5, movie6, movie7, movie8, movie9, movie10 }
};

List<Cinema> cinemas = new List<Cinema> { cinema1, cinema2, cinema3 };

// ─── Test output ──────────────────────────────────────────
//foreach (var m in cinema1.ListOfMovis)
//    Console.WriteLine($"{m.Title,-22} | {m.Genre,-7} | Rating: {m.Rating} | Ticket: ${m.TicketPrice}");


try
{
    // Step 1: Choose a cinema
    Console.WriteLine("=== Welcome to CinemaApp ===\n");
    Console.WriteLine("Available cinemas:");
    for (int i = 0; i < cinemas.Count; i++)
        Console.WriteLine($"  [{i + 1}] {cinemas[i].Name}");

    Console.Write("\nEnter cinema number: ");
    string cinemaInput = Console.ReadLine();

    if (!int.TryParse(cinemaInput, out int cinemaChoice) || cinemaChoice < 1 || cinemaChoice > cinemas.Count)
        throw new ArgumentException($"Invalid cinema choice: \"{cinemaInput}\"");

    Cinema selectedCinema = cinemas[cinemaChoice - 1];
    Console.WriteLine($"\nYou selected: {selectedCinema.Name}");

    // Step 2: Browse mode
    Console.WriteLine("\nBrowse by:");
    Console.WriteLine("  [1] All movies");
    Console.WriteLine("  [2] By genre");

    Console.Write("\nEnter choice: ");
    string modeInput = Console.ReadLine();

    if (!int.TryParse(modeInput, out int modeChoice) || modeChoice < 1 || modeChoice > 2)
        throw new ArgumentException($"Invalid choice: \"{modeInput}\". Enter 1 or 2.");

    // ── All Movies ────────────────────────────────────────
    if (modeChoice == 1)
    {
        Console.WriteLine($"\nMovies at {selectedCinema.Name}:");
        for (int i = 0; i < selectedCinema.ListOfMovis.Count; i++)
        {
            Movie m = selectedCinema.ListOfMovis[i];
            Console.WriteLine($"  [{i + 1}] {m.Title,-22} | {m.Genre,-7} | ★{m.Rating} | ${m.TicketPrice}");
        }

        Console.Write("\nChoose a movie: ");
        string movieInput = Console.ReadLine();

        if (!int.TryParse(movieInput, out int movieChoice) || movieChoice < 1 || movieChoice > selectedCinema.ListOfMovis.Count)
            throw new ArgumentException($"Invalid movie choice: \"{movieInput}\"");

        Movie selectedMovie = selectedCinema.ListOfMovis[movieChoice - 1];
        selectedCinema.MoviePlaying(selectedMovie);
    }

    // ── By Genre ──────────────────────────────────────────
    else if (modeChoice == 2)
    {
        Console.WriteLine("\nAvailable genres:");
        Genre[] genres = (Genre[])Enum.GetValues(typeof(Genre));
        for (int i = 0; i < genres.Length; i++)
            Console.WriteLine($"  [{i + 1}] {genres[i]}");

        Console.Write("\nEnter genre number: ");
        string genreInput = Console.ReadLine();

        if (!int.TryParse(genreInput, out int genreChoice) || genreChoice < 1 || genreChoice > genres.Length)
            throw new ArgumentException($"Invalid genre choice: \"{genreInput}\"");

        Genre selectedGenre = genres[genreChoice - 1];

        List<Movie> filtered = selectedCinema.ListOfMovis
            .Where(m => m.Genre == selectedGenre)
            .ToList();

        if (filtered.Count == 0)
            throw new InvalidOperationException($"No {selectedGenre} movies are playing at {selectedCinema.Name}.");

        Console.WriteLine($"\n{selectedGenre} movies at {selectedCinema.Name}:");
        for (int i = 0; i < filtered.Count; i++)
        {
            Movie m = filtered[i];
            Console.WriteLine($"  [{i + 1}] {m.Title,-22} | ★{m.Rating} | ${m.TicketPrice}");
        }

        Console.Write("\nChoose a movie: ");
        string movieInput = Console.ReadLine();

        if (!int.TryParse(movieInput, out int movieChoice) || movieChoice < 1 || movieChoice > filtered.Count)
            throw new ArgumentException($"Invalid movie choice: \"{movieInput}\"");

        Movie selectedMovie = filtered[movieChoice - 1];
        selectedCinema.MoviePlaying(selectedMovie);
    }
}
catch (ArgumentException ex)
{
    Console.WriteLine($"\n[Input Error] {ex.Message}");
}
catch (InvalidOperationException ex)
{
    Console.WriteLine($"\n[Error] {ex.Message}");
}
catch (Exception ex)
{
    Console.WriteLine($"\n[Unexpected Error] {ex.Message}");
}