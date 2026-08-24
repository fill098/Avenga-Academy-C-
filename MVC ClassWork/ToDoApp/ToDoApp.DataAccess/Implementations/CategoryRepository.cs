using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using ToDoApp.DataAccess.Interfaces;
using ToDoApp.Domain;

namespace ToDoApp.DataAccess.Implementations
{
    public class CategoryRepository : IRepository<Category>
    {
        private readonly ToDoAppDbContext _context;

        public CategoryRepository(ToDoAppDbContext context)
        {
            _context = context;
        }
        public List<Category> GetAll()
        {
            var categories = _context.Categories.ToList();
            return categories;
        }
        public Category GetById(int id)
        {
            var categories = _context.Categories.FirstOrDefault(x => x.Id == id);
            return categories;
        }
        public void Create(Category entity)
        {
            _context.Categories.Add(entity);
            _context.SaveChanges();
        }
        public void Update(Category entity)
        {
            _context.Categories.Update(entity);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var category = GetById(id);
            if (category != null)
            {
                _context.Categories.Remove(category);
                _context.SaveChanges();
            }
        }
    }
}
