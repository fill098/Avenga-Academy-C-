using ToDoApp.DataAccess.Interfaces;
using ToDoApp.Domain;

namespace ToDoApp.DataAccess.Implementations
{
    public class CategoryRepository : IRepository<Category>
    {


        public void Create(Category entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException(nameof(entity), "Category cannot be null.");
            }
            entity.Id = StaticDb.Categories.Last().Id + 1;
            StaticDb.Categories.Add(entity);
        }

        public void Delete(int id)
        {
            Category category = StaticDb.Categories.FirstOrDefault(c => c.Id == id);
            if (category == null)
            {
                throw new ArgumentNullException(nameof(id), "Category with id not found.");
            }
            StaticDb.Categories.Remove(category);
        }

        public List<Category> GetAll()
        {
            return StaticDb.Categories;
        }

        public Category GetById(int id)
        {
            var StaticDbCategory = StaticDb.Categories.FirstOrDefault(c => c.Id == id);
            if (StaticDbCategory == null)
            {
                throw new ArgumentNullException(nameof(id), "Category with id not found.");
            }
            return StaticDbCategory;
        }

        public void Update(Category entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException(nameof(entity), "Category with id not found.");
            }
            Category category = StaticDb.Categories.FirstOrDefault(c => c.Id == entity.Id);
            int index = StaticDb.Categories.IndexOf(category);
            StaticDb.Categories[index] = entity;
        }
    }
}
