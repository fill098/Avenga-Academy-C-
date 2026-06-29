using Class03.ASP.NET.MVC.MODEL.DataAccess;
using Class03.ASP.NET.MVC.MODEL.Models.Domains;
using Class03.ASP.NET.MVC.MODEL.Models.DTOs;

namespace Class03.ASP.NET.MVC.MODEL.Service
{
    public class StudentServices
    {
        //public Student GetStudentWithActiveCourse(int id)
        //{
        //    var student = InMemoryDb.Students.FirstOrDefault(s => s.Id == id);
        //    if (student == null)
        //    {
        //        throw new Exception($"Student with ID {id} not found.");
        //    }
        //    return student;
        //}

        public StudentWithCourseDTO GetStudentWithActiveCourse(int id)
        {
            var student = InMemoryDb.Students.FirstOrDefault(s => s.Id == id);
            if (student == null)
            {
                throw null;
            }
            var studentWithCourseDTO = new StudentWithCourseDTO
            {
                Id = student.Id,
                FullName = $"{student.FirstName} {student.LastName}",
                Age = DateTime.Now.Year - student.DateOfBirth.Year,
                NameOfActiveCourse = student.ActiveCourse.Name

            };
            return studentWithCourseDTO;
        }
    }
}
