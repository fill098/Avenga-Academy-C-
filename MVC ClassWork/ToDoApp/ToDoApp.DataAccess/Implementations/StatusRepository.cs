using System;
using System.Collections.Generic;
using System.Text;
using ToDoApp.DataAccess.Interfaces;
using ToDoApp.Domain;

namespace ToDoApp.DataAccess.Implementations
{
    public class StatusRepository : IRepository<Status>
    {
        private readonly ToDoAppDbContext _context;

        public StatusRepository(ToDoAppDbContext context)
        {
            _context = context;
        }
        public void Create(Status entity)
        {
            _context.Statuses.Add(entity);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var status = GetById(id);
            if (status != null)
            {
                _context.Statuses.Remove(status);
                _context.SaveChanges();
            }
        }

        public List<Status> GetAll()
        {
            var stauses = _context.Statuses.ToList();
            return stauses;
        }

        public Status GetById(int id)
        {
            var status = _context.Statuses.FirstOrDefault(x => x.Id == id);
            return status;
        }

        public void Update(Status entity)
        {
            _context.Statuses.Update(entity);
            _context.SaveChanges();
        }
    }
}
