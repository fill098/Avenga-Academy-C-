using AcademyManagement.Domain.Enum;

namespace AcademyManagement.Domain.Models
{
    public class Student : User
    {
        public string CurrentSubject { get; set; }

        public Dictionary<string,int> SubjectGrades { get; set; }

        public Student(string fname, string lname, string username, string password,  int age) 
            : base(fname, lname, password, username, age)

        {
            Role = Role.Student;
        }

        public Student(string username, string password) : base(username, password)
        {
            Role = Role.Student;
        }



    }
}
