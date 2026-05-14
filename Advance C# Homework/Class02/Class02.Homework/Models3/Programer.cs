namespace Class02.Homework.Models3
{
    public class Programer : Employee
    {
        public double HourlyRate { get; set; }

        public double HoursWorked { get; set; }

      

        public override double CalculateSalary()
        {
            double salary = HourlyRate + HoursWorked;
            return salary;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"{Id}) {Name} - {Role} - Salary: {CalculateSalary()} ");
        }
    }
}
