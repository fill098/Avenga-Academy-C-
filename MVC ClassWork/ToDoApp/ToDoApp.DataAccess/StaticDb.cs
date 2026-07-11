using System.Linq;
using ToDoApp.Domain;

namespace ToDoApp.DataAccess
{
    public static class StaticDb
    {
        public static List<ToDo> Todos { get; set; }
        public static List<Category> Categories { get; set; }
        public static List<Status> Statuses { get; set; }
        static StaticDb()
        {
            LoadCategories();
            LoadStatuses();
            LoadToDos();
        }

        public static void LoadCategories()
        {
            Categories = new List<Category>()
            {
                new Category { Id = 1, Name = "Work"},
                new Category { Id = 2, Name = "Home"},
                new Category { Id = 3, Name = "Exercise"},
                new Category { Id = 4, Name = "Shopping"},
                new Category { Id = 5, Name = "Hoby"},
                new Category { Id = 6, Name = "FreeTime"},
            };
        }

        public static void LoadStatuses()
        {
            Statuses = new List<Status>()
            {
                new Status { Id = 1, Name = "In Progress"},
                new Status { Id = 2, Name = "Completed"}
            };
        }

        public static void LoadToDos()
        {
            Todos = new List<ToDo>
            {
                new ToDo {
                    Id = 1,
                    Description = "Finish project presentation",
                    DueDate = DateTime.Now.AddDays(2),
                    CategoryId = 1, //Work
                    Category = Categories.FirstOrDefault(c => c.Id == 1),
                    StatusId = 1, //In Progress
                    Status = Statuses.FirstOrDefault(s => s.Id == 1)
                  },
                 new ToDo {
                    Id = 2,
                    Description = "Clean the house",
                    DueDate = DateTime.Now.AddDays(1),
                    CategoryId = 2, //Home
                    Category = Categories.FirstOrDefault(c => c.Id == 2),
                    StatusId = 1, //In Progress
                    Status = Statuses.FirstOrDefault(s => s.Id == 1)
                  },
                  new ToDo {
                    Id = 3,
                    Description = "Morning exercise",
                    DueDate = DateTime.Now,
                    CategoryId = 3, //Exercise
                    Category = Categories.FirstOrDefault(c => c.Id == 3),
                    StatusId = 2, //Completed
                    Status = Statuses.FirstOrDefault(s => s.Id == 2)
                  },
                   new ToDo {
                    Id = 4,
                    Description = "Buy groceries",
                    DueDate = DateTime.Now.AddDays(3),
                    CategoryId = 4, //Shopping
                    Category = Categories.FirstOrDefault(c => c.Id == 4),
                    StatusId = 1, //In Progress
                    Status = Statuses.FirstOrDefault(s => s.Id == 1)
                  },
                   new ToDo {
                    Id = 5,
                    Description = "Watch a movie",
                    DueDate = DateTime.Now,
                    CategoryId = 6, //FreeTime
                    Category = Categories.FirstOrDefault(c => c.Id == 6),
                    StatusId = 2, //Completed
                    Status = Statuses.FirstOrDefault(s => s.Id == 2)
                  },
            };
        }
    }
}