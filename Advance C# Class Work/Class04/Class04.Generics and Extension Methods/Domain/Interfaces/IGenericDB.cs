namespace Class04.Generics_and_Extension_Methods.Domain.Interfaces
{
    public interface IGenericDB<T>
    {
        void PrintAll();

        T GetById(int id);

        T GetByIndex(int id);

        void Insert(T entity);

        void RemoveById(int id);


    }
}
