using ToDoApp.DataAccess.Interfaces;
using ToDoApp.Domain;
using ToDoApp.Models.ViewModels;
using ToDoApp.Services.Interfaces;
using ToDoApp.Mappr;

namespace ToDoApp.Services.Implementations
{
    public class ToDoService : IToDoService
    {
        private readonly IRepository<ToDo> _toDoRepository;

        public ToDoService(IRepository<ToDo> roDoRepository)
        {
            _toDoRepository = roDoRepository;
        }
        public List<ToDosVM> GetAllToDos(int? categoryId, int? statusId)
        {
            List<ToDo> todos = _toDoRepository.GetAll();
            // FILTERING
            if(categoryId.HasValue && categoryId.Value > 0)
            {
                todos = todos.Where(t => t.CategoryId == categoryId.Value).ToList();
            }
            if (statusId.HasValue && statusId.Value > 0)
            {
                todos = todos.Where(t => t.StatusId == statusId.Value).ToList();
            }

            var todosVM = new List<ToDosVM>();

            foreach (var todo in todos)
            {
                var todoVM= OptionalMapper.MapToDos(todo);
                todosVM.Add(todoVM);
            }
            return todosVM;
        }
    }
}
