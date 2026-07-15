using System;
using System.Collections.Generic;
using System.Text;
using ToDoApp.DataAccess.Interfaces;

namespace ToDoApp.DataAccess.Implementations
{
    public class EFToDoRepository : IRepository<T>
    {
        public void Create(T entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<T> GetAll()
        {
            throw new NotImplementedException();
        }

        public T GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(T entity)
        {
            throw new NotImplementedException();
        }
    }
}
