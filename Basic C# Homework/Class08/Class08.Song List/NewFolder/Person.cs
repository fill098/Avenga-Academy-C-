
namespace Class08.Song_List.NewFolder
{
    public class Person
    {
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int Age { get; set; }

        public Genre FavoriteMusicType { get; set; }

        public List<Song> FavoriteSongs { get; set; }

        public Person(int id, string fname, string lname, int age, Genre favoriteMusicType, List<Song> favoriteSongs)
        {

            Id = id;
            FirstName = fname;
            LastName = lname;
            Age = age;
            FavoriteMusicType = favoriteMusicType;
            FavoriteSongs = favoriteSongs ?? new List<Song>();
        }



        public void GetFavSongs()
        {
            if (FavoriteSongs.Count   ==  0)
            {
                Console.WriteLine($"{FirstName} {LastName} hates music!!");
             
            }
            else
            {
                Console.WriteLine($"{FirstName} {LastName} favorate song are:");
                foreach (var song in FavoriteSongs)
                {
                    Console.WriteLine($"Name: {song.Titile}");
                    Console.WriteLine($"Genre: {song.Genre}");
                    Console.WriteLine($"Length in seconds: {song.Seconds}s");
                }
            }

            


        }

    }
}
