using Class04.Generics_and_Extension_Methods.Domain.Interfaces;
using Class04.Generics_and_Extension_Methods.Domain.Models;

namespace Class04.Generics_and_Extension_Methods.Domain.Data
{
    public class GenericDb<T> : IGenericDB<T> where T : BaseEntity
    {
        private List<T> Db;
        public GenericDb()
        {
            Db = new List<T>();
        }

        public void PrintAll()
        {
            Console.WriteLine($"\nPrinting items form {typeof(T).Name}");
            foreach (T item in Db)
            {
                Console.WriteLine(item.GetInfo());
                
            }
        }

        public T GetById(int id)
        {
            T item = Db.FirstOrDefault(i => i.Id == id);
            return item;
        }

        public T GetByIndex(int index)
        {
            //T item = Db.FirstOrDefault(i => i.Id)
            return Db[index];
        }

       public  void Insert(T entity)
        {
            Db.Add(entity);
            Console.WriteLine($"Items was added in the {typeof(T)}");
        }


        public void RemoveById(int id)
        {
            T item = GetById(id);
            Db.Remove(item);
            
        }
    }
}
