using EFDataBaseFirstDemo.Domain.Context;
using EFDataBaseFirstDemo.Domain.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EFDataBaseFirstDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TodosController : ControllerBase
    {
        private readonly  AppDbContext _context;
        public TodosController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]

        public ActionResult<List<Todo>> GetAll()
        {
            List<Todo> todos = _context.Todos
                .Include(todo => todo.Category)
                .Include(todo => todo.Status)
                .ToList();

            return Ok(todos);
        }
    }
}
