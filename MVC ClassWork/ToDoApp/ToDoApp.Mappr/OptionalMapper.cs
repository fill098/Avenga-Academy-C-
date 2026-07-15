using ToDoApp.Domain;
using ToDoApp.Models.Dtos;
using ToDoApp.Models.ViewModels;

namespace ToDoApp.Mappr
{
    public static class OptionalMapper
    {
        public static ToDosVM MapToDosVM(ToDo todo, string categoryName, string statusName)
        {
            return new ToDosVM
            {
                Id = todo.Id,
                Description = todo.Description,
                DueDate = todo.DueDate,
                StatusName = statusName ?? string.Empty,
                CategoryName = categoryName ?? string.Empty
            };
        }
        public static CategoryDto MapToCategoryDto(Category category)
        {
            return new CategoryDto
            {
                Id = category.Id,
                Name = category.Name,
            };
        }


        public static StatusDto MapToCategoryDto(Status status)
        {
            return new StatusDto
            {
                Id = status.Id,
                Name = status.Name,
            };
        }

    }
}
