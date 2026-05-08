    using ClassLibraryEmploy;
    using EnumRole;
    using System;
    using System.Collections.Generic;
    using System.Text;

    namespace Class07.class_library_project_.Models
    {
        internal class Manager : Employee
        {
            private double Bonus { get; set; }



            public Manager(string firstName, string lastName, Role role, double salary) 
                : base(firstName, lastName, role, salary)
            {
                Bonus = 0;
            }


            public void AddBonus(double number)
            {
                Bonus += number;
            }


            public override double GetSalary()
            {
                return Salary + Bonus;
            }

        }

    
    }
