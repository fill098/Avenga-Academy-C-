namespace Class02.Homework.Models3
{
    public class Manager : Employee
    {
        public double BaseSalary { get; set; }

        public double Bonus { get; set; }

        public override double CalculateSalary()
        {
            double salary = BaseSalary + Bonus;
            return salary;
            
        }


        public override void DisplayInfo()
        {
            Console.WriteLine($"{Id}) {Name} - {Role} - Salary: {CalculateSalary()}");
        }
    }
}
