using System.Runtime.Intrinsics.X86;

namespace Class_Exercises
{
    public class Human
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Age { get; set; }
        public string FullName()
        {
            return $"The {Name} {Surname} and his age is: {Age}";
        }

        public Human(string fname, string lname, string age)
        {

            Name = fname;
            Surname = lname;
            Age = age;
            
        }

        public Human()
        {
            
        }


      

    }
}
