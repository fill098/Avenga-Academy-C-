using AcademyManagment.Domain.Enums;

namespace AcademyManagment.Domain.Models
{
    public class Student : User
    {
        public string CurrentSubject { get; set; }

        public Dictionary<string, int> SubjectGrade { get; set; }
        public Student(string useername, string password) 
            : base(useername, password)
        {
            Role = Role.Student;
        }

        public Student(string firstName, string lastName, string username, string password, int age) 
            : base(firstName, lastName, username, password, age)
        {
            Role = Role.Student;
        }
    }
}
