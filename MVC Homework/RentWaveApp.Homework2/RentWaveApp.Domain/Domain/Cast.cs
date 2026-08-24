using RentWaveApp.Domain.Enum;

namespace RentWaveApp.Domain.Domain
{
    public class Cast : BaseEntity
    {
        public Movie Movie { get; set; }
        public int MovieId { get; set; }
        public string Name { get; set; }
        public Part PartName { get; set; }
    }
}
