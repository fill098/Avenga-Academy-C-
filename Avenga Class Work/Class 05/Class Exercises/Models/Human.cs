

namespace Class_Exercises.Models
{
    public class Human
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Age { get; set; }

        public Human()
        {

        }
        

        public string FullName()
        {
            return $"The human {Name} {Surname} and his age is: {Age}";
        }




    }
}
