using ClassLibraryEmploy;
using EnumRole;


namespace Class07.class_library_project_.Models
{
    public class SalesPerson : Employee
    {
        private double SuccessSaleRevenue { get; set; }

        public SalesPerson(string firstName, string lastName) 
            : base(firstName, lastName, Role.Sales, 500)
        {
            SuccessSaleRevenue = 0;
        }


        public void AddSuccessRevenue(double number)
        {
            SuccessSaleRevenue += number;

        }


        public override double GetSalary()
        {
            if (SuccessSaleRevenue <= 2000)
            {
                return Salary + 500;
            }
            else if (SuccessSaleRevenue <= 5000)
            {
                return Salary + 1000;
            }
            else 
            {
                return Salary + 1500;
            }
        }

    }

    
}
