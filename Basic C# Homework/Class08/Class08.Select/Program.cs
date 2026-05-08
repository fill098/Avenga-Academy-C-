using Class08.Song_List.NewFolder;
#region EXERCISE 2
/*

Select the person Jerry and add all the songs which start with the letter B.

Select the person Maria and add all the songs with length longer than 6 min.

Select the person Jane and add all the songs that are of genre Rock.

Select the person Stefan and add all songs shorter than 3 min and of genre Hip-Hop.

Select all persons from the persons array that have 4 or more songs.
*/



List<Song> songs = new List<Song>
{
    new Song("Back in Black", 255, Genre.Rock),
    new Song("Born to Run", 270, Genre.Rock),
    new Song("Bohemian Rhapsody", 354, Genre.Rock),
    new Song("Blinding Lights", 200, Genre.Rock),
    new Song("Thunderstruck", 292, Genre.Rock),
    new Song("Smells Like Teen Spirit", 301, Genre.Rock),
    new Song("Lose Yourself", 326, Genre.Hip_hop),
    new Song("HUMBLE.", 177, Genre.Hip_hop),
    new Song("God's Plan", 198, Genre.Hip_hop),
    new Song("Sicko Mode", 312, Genre.Hip_hop),
    new Song("Sandstorm", 231, Genre.Techno),
    new Song("Blue (Da Ba Dee)", 230, Genre.Techno),
    new Song("Moonlight Sonata", 915, Genre.Clasical),
    new Song("The Four Seasons", 1560, Genre.Clasical),
    new Song("Beethoven Symphony", 420, Genre.Clasical)
};
List<Person> persons = new List<Person>
{
    new Person(1, "Jerry", "Adams", 25, Genre.Rock, new List<Song>()),
    new Person(2, "Maria", "Lopez", 31, Genre.Clasical, new List<Song>()),
    new Person(3, "Jane", "Brown", 22, Genre.Rock, new List<Song>()),
    new Person(4, "Stefan", "Petrov", 29, Genre.Hip_hop, new List<Song>()),
    new Person(5, "Alex", "Turner", 27, Genre.Techno, new List<Song>())
};

Person jerry = persons.Where(x => x.FirstName == "Jerry").FirstOrDefault();
jerry.FavoriteSongs = songs.Where(x => x.Titile.StartsWith("B")).ToList();
jerry.GetFavSongs();
Console.WriteLine("-------------------------");

Person marria = persons.Where(x => x.FirstName == "Maria").FirstOrDefault();
marria.FavoriteSongs = songs.Where(x => x.Seconds > 360).ToList();
marria.GetFavSongs();
Console.WriteLine("-------------------------");

Person jane = persons.Where(x => x.FirstName == "Jane").FirstOrDefault();
jane.FavoriteSongs = songs.Where(x => x.Genre == Genre.Rock).ToList();
jane.GetFavSongs();
Console.WriteLine("-------------------------");

Person stefan = persons.Where(x => x.FirstName == "Stefan").FirstOrDefault();
stefan.FavoriteSongs = songs.Where(x => x.Seconds < 180 && x.Genre == Genre.Hip_hop).ToList();
stefan.GetFavSongs();
Console.WriteLine("-------------------------");


var result = persons.Where(x => x.FavoriteSongs.Count >= 4).ToList();
Console.WriteLine("Persons who have more then 4 songs:");
foreach (var item in result)
{
    Console.WriteLine($"{item.FirstName}");
}











#endregion