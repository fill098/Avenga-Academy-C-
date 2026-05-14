namespace Class02.Homework.Models3
{
    public abstract class Employee
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public Role Role { get; set; }
        


        public abstract double CalculateSalary();


        public abstract void DisplayInfo();

    }
}
