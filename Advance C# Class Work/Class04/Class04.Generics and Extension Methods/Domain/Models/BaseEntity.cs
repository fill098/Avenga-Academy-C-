namespace Class04.Generics_and_Extension_Methods.Domain.Models
{
    public abstract class BaseEntity
    {
        public int Id { get; set; }

        public abstract string GetInfo();
    }
}
