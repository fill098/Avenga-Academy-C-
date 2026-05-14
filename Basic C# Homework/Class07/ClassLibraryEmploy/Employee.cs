
using EnumRole;
namespace ClassLibraryEmploy
{
    public class Employee
    {
        public string FirtName { get; set; }

        public string LastName { get; set; }

        public Role Role { get; set; }

        protected double Salary { get; set; }

        public Employee(string firstName, string lastName, Role role, double salary)
        {
            FirtName = firstName;
            LastName = lastName;
            Role = role;
            Salary = salary;
        }



        public void PrintInfo()
        {
            Console.WriteLine($"Name: {FirtName} {LastName}");
            Console.WriteLine($"Role: {Role}");
            Console.WriteLine($"Salary: {GetSalary()}");
        }


        public virtual double GetSalary()
        {
            return Salary;
        }




    }
}
