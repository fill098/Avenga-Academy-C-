using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using ToDoApp.DataAccess.Interfaces;
using ToDoApp.Domain;

namespace ToDoApp.DataAccess.Implementations
{
    public class ToDoRepository : IRepository<ToDo>
    {
        private readonly ToDoAppDbContext _context;

        public ToDoRepository(ToDoAppDbContext context)
        {
            _context = context;
        }
        public List<ToDo> GetAll()
        {
            var toDos = _context.ToDos
                .Include(x => x.Status)
                .Include(x => x.Status)
                .ToList();
            return toDos;
        }
        public ToDo GetById(int id)
        {
            var toDo = _context.ToDos
                .Include(x => x.Status)
                .Include(x => x.Category)
                .FirstOrDefault(x => x.Id == id);
            return toDo;
        }
        public void Create(ToDo entity)
        {
            _context.ToDos.Add(entity);
            _context.SaveChanges();
        }
        public void Update(ToDo entity)
        {
            _context.ToDos.Update(entity);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var todo = GetById(id);
            if (todo != null)
            {
                _context.ToDos.Remove(todo);
                _context.SaveChanges();
            }
        }
    }
}
