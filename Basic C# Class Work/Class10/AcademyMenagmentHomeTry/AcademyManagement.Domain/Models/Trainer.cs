using AcademyManagement.Domain.Enum;

namespace AcademyManagement.Domain.Models
{
    public class Trainer : User
    {
        public Trainer(string fname, string lname, string username, string password,int age) 
            : base(fname, lname, password, username, age)
        {
            Role = Role.Trainer;
        }


        public Trainer(string username, string password) : base (username, password)
        {
            Role = Role.Trainer;
        }
    }
}
