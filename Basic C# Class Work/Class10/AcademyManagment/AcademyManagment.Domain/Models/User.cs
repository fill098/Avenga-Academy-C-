using AcademyManagment.Domain.Enums;

namespace AcademyManagment.Domain.Models
{
    public class User
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int Age { get; set; }
        public string Usename { get; set; }

        public string Password { get; set; }
        public Role Role { get; set; }

        public User(string firstName , string lastName, string  username, string password, int age)
        {
            
            FirstName = firstName;
            LastName= lastName;
            
            Usename = username;
            Password = password;
            Age = age;
        }

        public User(string useername, string password)
        {
            Usename = useername;
            Password = password;
            
        }

        public string GetFullName()
        {
            return $"{FirstName} {LastName}";
        }
    }
}
