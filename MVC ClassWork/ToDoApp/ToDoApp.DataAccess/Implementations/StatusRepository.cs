using ToDoApp.DataAccess.Interfaces;
using ToDoApp.Domain;

namespace ToDoApp.DataAccess.Implementations
{
    public class StatusRepository : IRepository<Status>
    {
        public void Create(Status entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException(nameof(entity), "Status item cannot be null.");
            }
            entity.Id = StaticDb.Statuses.Last().Id + 1;
            StaticDb.Statuses.Add(entity);
        }

        public void Delete(int id)
        {
            Status status = StaticDb.Statuses.FirstOrDefault(s => s.Id == id);
            if (status == null)
            {
                throw new ArgumentNullException(nameof(status), "Status item cannot be null.");
            }
            StaticDb.Statuses.Remove(status);
        }

        public List<Status> GetAll()
        {
            return StaticDb.Statuses.ToList();
        }

        public Status GetById(int id)
        {
            var status = StaticDb.Statuses.FirstOrDefault(s => s.Id == id);
            if (status == null)
            {
                throw new ArgumentNullException(nameof(status), "Status item cannot be null.");
            }
            return status;

        }

        public void Update(Status entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException(nameof(entity), "Status itme cannot be null.");
            }
            Status status = GetById(entity.Id);
            int index = StaticDb.Statuses.IndexOf(status);
            StaticDb.Statuses[index] = entity;
        }
    }
}
