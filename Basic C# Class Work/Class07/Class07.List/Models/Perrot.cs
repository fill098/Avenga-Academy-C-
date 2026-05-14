using System;
using System.Collections.Generic;
using System.Text;

namespace Class07.Inheritance.Models
{
    public class Perrot : Animal
    {
        public string Color { get; set; }

        public Perrot(int id, string name, string type, string color) 
            : base(id,name,type)
        {
            Color = color;
        }

        public Perrot()
        {
            
        }

        public void Fly()
        {
            Console.WriteLine("Woow! I am flying");
        }

        public override void Eat()
        {
            Console.WriteLine($"I am {Name} and I am {Type} and i dont have time to eat!!!");
        }

    }
}
