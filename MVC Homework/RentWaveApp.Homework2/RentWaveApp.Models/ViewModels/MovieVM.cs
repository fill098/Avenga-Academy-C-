namespace RentWaveApp.Models.ViewModels
{
    public class MovieVM
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Genre { get; set; }
        public string Language { get; set; }
        public bool IsAvailable { get; set; }
        public int Quantity { get; set; }
        public DateTime ReleaseDate { get; set; }
        public TimeSpan Length { get; set; }
    }
}
