
using AcademyManagement.Domain.Enum;

namespace AcademyManagement.Domain.Models
{
    public class User
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int Age { get; set; }
        public string  UserName { get; set; }

        public string Password { get; set; }

        public Role Role { get; set; }


        public User(string fname, string lname, string username, string password, int age)
        {
            FirstName = fname;
            LastName = lname;
            UserName = username;
            Password = password;
            Age = age;
        }



        public User(string username, string password)
        {
            UserName = username;
            Password = password;
        }



        public void GetFullName()
        {
            Console.WriteLine($"{FirstName} {LastName}");
        }




    }
}
