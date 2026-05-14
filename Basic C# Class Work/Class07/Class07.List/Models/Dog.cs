using System;
using System.Collections.Generic;
using System.Text;

namespace Class07.Inheritance.Models
{
    public class Dog : Animal
    {
        public string Race { get; set; }


        public Dog()
        {
            Console.WriteLine("A new istance of dog has been created an also the defualt paretnt Constructor!");
            Thread.Sleep(2000);
        }
        public void Bark()
        {
            Console.WriteLine("Woof Woof Woof Woof");
        }

        public override void Eat()
        {
            Console.WriteLine($"Hi people! I am {Name} the {Type} and I am eating!");
        }
    }
}
