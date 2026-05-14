using System;
using System.Collections.Generic;
using System.Text;

namespace Class06.Exersises.Models
{
    internal class Task1
    {
        public static void NumberStats(double number)
        {
            Console.WriteLine($"Stats for number: {number}");
            Console.WriteLine();

            
            if (number >= 0)
                Console.WriteLine("Positive");
            else
                Console.WriteLine("Negative");

           
            if (number % 1 == 0)
                Console.WriteLine("Integer");
            else
                Console.WriteLine("Decimal");

            
            if (number % 2 == 0)
                Console.WriteLine("Even");
            else
                Console.WriteLine("Odd");
        }
    }
}

