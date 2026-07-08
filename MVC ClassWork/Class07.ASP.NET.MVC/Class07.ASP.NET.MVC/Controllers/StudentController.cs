using Class07.ASP.NET.MVC.Database;
using Class07.ASP.NET.MVC.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Class07.ASP.NET.MVC.Mapper;

namespace Class07.ASP.NET.MVC.Controllers
{
    [Route("students")]
    public class StudentController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            List<StudentVM> students = StaticDb.Students.Select(x =>
            Mapper.Mapper.MapToStudentVM(x)
            ).ToList();
            return View(students);
        }


        [HttpGet("{id}")]
        public IActionResult GetStudentById([FromRoute] int id)
        {
            var student = StaticDb.Students.FirstOrDefault(x => x.Id == id);
            if (student == null)
            {
                return NotFound();
            }

            var studentVM = Mapper.Mapper.MapToStudentVM(student);
            return View("StudentDetails", studentVM);
        }

        public IActionResult GetStudnetFillter(string fullName, int id)
        {
            var studnet = StaticDb.Students.FirstOrDefault(x => (DateTime.Now.Year - x.DateOfBirth.Year) == )
        }
    }
}
