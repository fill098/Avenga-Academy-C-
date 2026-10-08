

namespace PizzaApp.Domain.Common
{
    public abstract class BaseEntity
    {
        public int Id { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdateDate { get; set; }

        protected BaseEntity()
        {
            CreatedDate = DateTime.Now;
            UpdateDate = DateTime.Now;
        }
    }
}
