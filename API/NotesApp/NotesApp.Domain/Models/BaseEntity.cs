namespace NotesApp.Domain.Models
{
    public class BaseEntity
    {
        public int Id { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdateDate { get; set; }

        public BaseEntity()
        {
            CreatedDate = DateTime.UtcNow;
            UpdateDate = DateTime.UtcNow;
        }
    }
}
