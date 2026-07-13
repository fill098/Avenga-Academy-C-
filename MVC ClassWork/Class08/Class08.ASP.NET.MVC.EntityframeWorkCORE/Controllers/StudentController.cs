using Class08.ASP.NET.MVC.EntityframeWorkCORE.DataAccess;
using Class08.ASP.NET.MVC.EntityframeWorkCORE.Models.Domain;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Class08.ASP.NET.MVC.EntityframeWorkCORE.Controllers
{
    [Route("students")]
    public class StudentController : Controller
    {
        
        private readonly DemoDbContext _context;

        public StudentController(DemoDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            List<Student> students = _context.Students.ToList();
            return View(students);
        }

        [HttpGet("create")]
        public IActionResult Create()
        {
            var courses = _context.Courses.ToList();
            ViewBag.Courses = new SelectList(courses, "Id", "Name");
            return View();
        }

        [HttpPost("create")]
        public IActionResult Create([FromForm]Student student)
        {
            _context.Students.Add(student);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}
