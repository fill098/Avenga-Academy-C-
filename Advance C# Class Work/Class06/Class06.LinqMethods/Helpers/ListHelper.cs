using Class06.LinqMethods.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Class06.LinqMethods.Helpers
{
    public static class ListHelper
    {
        public static void PrintSimple<T>(this IEnumerable<T> list)
        {
            Console.WriteLine("Printing List...");
            Console.WriteLine("------------------------------");
            foreach (T item in list)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("------------------------------");
        }

        public static void PrintEntities<T>(this List<T> list) where T : BaseEntity
        {
            Console.WriteLine($"Printing {typeof(T).Name}s...");
            Console.WriteLine("------------------------------");
            foreach (T item in list)
            {
                Console.WriteLine(item.GetInfo());
            }
            Console.WriteLine("------------------------------");
        }
    }
}
