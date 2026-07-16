using RentWaveApp.Models.Enums;

namespace RentWaveApp.Models.Domain
{
    public class Movie : BaseEntity
    {
        public string Title { get; set; }
        public Genre GenreName { get; set; }
        public Language LanguageName { get; set; }
        public bool IsAvailable { get; set; }
        public DateTime ReleaseDate { get; set; }
        public TimeSpan Length { get; set; }
        public int AgeRestriction { get; set; }
        public int Quantity { get; set; }
    }
}
