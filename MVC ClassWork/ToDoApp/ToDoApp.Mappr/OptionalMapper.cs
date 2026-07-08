using ToDoApp.Domain;
using ToDoApp.Models.ViewModels;

namespace ToDoApp.Mappr
{
    public static class OptionalMapper
    {
        public static ToDosVM MapToDos(ToDo todo)
        {
            return new ToDosVM
            {
                Id = todo.Id,
                Description = todo.Description,
                DueDate = todo.DueDate,
                StatusName = todo.Status?.Name ?? string.Empty,
                StatusId = todo.Status.Id,
                CategoryName = todo.Category?.Name ?? string.Empty,
                CategoryId = todo.Category.Id
            };
        }
    }
}
