using AcademyManagement.Domain.Enum;

namespace AcademyManagement.Domain.Models
{
    public class Admin : User
    {

        public Admin(string fname, string lname, string username, string password, int age) 
            : base(fname, lname, password, username, age)
        {
            Role = Role.Admin;
            
        }


        public Admin(string username, string password) : base(username, password)
        {
            Role = Role.Admin;
        }
    }
}
