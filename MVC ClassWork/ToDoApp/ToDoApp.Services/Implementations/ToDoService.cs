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
        private readonly IRepository<Category> _categoryRepository;
        private readonly IRepository<Status> _statusRepository;


        public ToDoService(IRepository<ToDo> roDoRepository, IRepository<Category> categoryRepository, IRepository<Status> statusRepository)
        {
            _toDoRepository = roDoRepository;
            _categoryRepository = categoryRepository;
            _statusRepository = statusRepository;
            
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
                var category = _categoryRepository.GetById(todo.CategoryId);
                var status = _statusRepository.GetById(todo.StatusId);

                var todoVM= OptionalMapper.MapToDosVM(todo, category.Name, status.Name);
                todosVM.Add(todoVM);
            }
            return todosVM;
        }
    }
}
