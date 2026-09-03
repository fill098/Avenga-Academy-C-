using NotesApp.Domain.Models;

<<<<<<< HEAD
namespace NotesApp.DataAccess.Interfaces
{
    public interface IRepository<T> where T : BaseEntity
    {
        List<T> GetAll();
        T? GetById(int id);
        List<T> GetByIds(List<int> ids);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);

    }
=======
namespace NotesApp.DataAccess.Interfaces;

public interface IRepository<T> where T : BaseEntity
{
    Task<List<T>> GetAllAsync();
    Task<T?> GetByIdAsync(int id);
    Task<List<T>> GetByIdsAsync(List<int> ids);
    Task AddAsync(T entity);
    Task UpdateAsync(T entity);
    Task DeleteAsync(T entity);
>>>>>>> origin/main
}
