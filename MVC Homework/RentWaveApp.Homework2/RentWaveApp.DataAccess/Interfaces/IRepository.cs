using RentWaveApp.Domain.Domain;

namespace RentWaveApp.DataAccess.Interfaces
{
    public interface IRepository<T> where T : BaseEntity
    {
        List<T> GetAll();
        T GetById(int id);
        void Create(T entity);
        void Update(T entity);
        void Delete(int id);
    }
}
