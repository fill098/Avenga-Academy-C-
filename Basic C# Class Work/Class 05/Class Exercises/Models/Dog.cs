using System;
using System.Collections.Generic;
using System.Text;

namespace Class_Exercises.Models
{
    public class Dog
    {
        public  string Name { get; set; }
        public string Race { get; set; }
        public string Color { get; set; }


        public Dog(string name, string race, string color)
        {
            Name = name;
            Race = race;
            Color = color;
        }


        public void Eat()
        {
             
             Console.WriteLine($"The dog {Name} with {Color} is eating!!");

        }



        public void Play()
        {
            Console.WriteLine($"The dog {Name} with {Color} is playing!!");
        }


        public void ChaseTail()
        {
            Console.WriteLine($"The dog {Name} with {Color} is now chasing his tail!!");
        }

    }

    

}
