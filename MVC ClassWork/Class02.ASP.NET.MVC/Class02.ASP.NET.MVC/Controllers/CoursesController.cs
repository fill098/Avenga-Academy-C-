using Class02.ASP.NET.MVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace Class02.ASP.NET.MVC.Controllers
{
    public class CoursesController : Controller
    {

        private List<Course> _courses = new List<Course>()
        {
            new Course() { Id = 1, Name = "C# Basics", NumberOfClasses = 10 },
            new Course() { Id = 2, Name = "ASP.NET MVC", NumberOfClasses = 15 },
            new Course() { Id = 3, Name = "Entity Framework", NumberOfClasses = 12 }
        };

        // GET: by deafult
        public IActionResult GetAllCurses()
        {
            return Json(_courses);
        }

        public IActionResult GetCourseById(int id)
        {
            return Json(_courses.FirstOrDefault(x => x.Id == id));
        }

        public JsonResult GetCourseByName(string name)
        {
            return Json(_courses.FirstOrDefault(x => x.Name == name));
        }

        public IActionResult GetCoursesByIdAndName(int id, string name)
        {
            return Json(_courses.FirstOrDefault(x => x.Id == id && x.Name == name));
        }
    }
}
