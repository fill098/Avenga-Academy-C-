using Class07.ASP.NET.MVC.Models.Domain;
using Class07.ASP.NET.MVC.Models.ViewModels;

namespace Class07.ASP.NET.MVC.Mapper
{
    public class Mapper
    {
        public static StudentVM MapToStudentVM(Student student)
        {
            return new StudentVM
            {
                Id = student.Id,
                FullName = student.GetFullName(),
                Age = DateTime.Now.Year - student.DateOfBirth.Year,
                Email = student.Email
            };
        }
    }
}
