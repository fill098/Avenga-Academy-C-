
namespace Class08.Song_List.NewFolder
{
    public class Song
    {
        public string Titile { get; set; }

        public int Seconds { get; set; }

        public Genre Genre { get; set; }

        public Song(string title, int seconds, Genre genre)
        {
            Titile = title;
            Seconds = seconds;
            Genre = genre;

        }
    }
}
