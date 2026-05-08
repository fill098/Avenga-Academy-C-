using System;
using System.Collections.Generic;
using System.Text;

namespace Class06.Exersises.Models
{
    internal class Task2
    {

        public static  void NumberStats(double number)
        {
            Console.WriteLine($"The stats for number is {number}");
            Console.WriteLine();

            if(number >= 0)
            {
                Console.WriteLine("Positiv");
            }
            else
            {
                Console.WriteLine("Negativ");
            }

            if (number)
            {

            }
        }
    }
}
