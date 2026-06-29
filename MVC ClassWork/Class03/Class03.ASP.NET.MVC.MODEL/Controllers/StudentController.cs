using Class03.ASP.NET.MVC.MODEL.Service;
using Microsoft.AspNetCore.Mvc;

namespace Class03.ASP.NET.MVC.MODEL.Controllers
{
    [Route("students")]
    public class StudentController : Controller
    {
        private StudentServices _studentService;

        public StudentController()
        {
            _studentService = new StudentServices();
        }

        [HttpGet("getById/{id:int}")]

        public IActionResult GetStudentById(int id)
        {
            var student = _studentService.GetStudentWithActiveCourse(id);
            if(student == null) {
                return Content("Student not found!!!");
            }
            return Json(student);
        }
    }
}
