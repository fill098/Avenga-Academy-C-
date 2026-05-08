using System;
using System.Collections.Generic;
using System.Text;

namespace Class07.Inheritance.Models
{
    public class Cat : Animal
    {
        public string Lazyness { get; set; }

        public Cat() : base("Cat")
        {
            Console.WriteLine("A new instanc of cat is created usinig the paraent constructor that requires a string!");
            Thread.Sleep(2000);
        }

        public void Meow()
        {
            Console.WriteLine("Meow, Meow!");
        }

        public override void Eat()
        {
            Console.WriteLine("You dont tell a cant when to eat! A CAT EATS WHEN it WANTS");
        }



    }
}
