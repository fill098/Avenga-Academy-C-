using System;
using System.Collections.Generic;
using System.Text;

namespace Task2.Models
{
    internal class User
    {

        public int ID { get; set; }
        public string UserName { get; set; }

        public string Password { get; set; }

        public string[] Messages { get; set; }


        public void Menu()
        {
            Console.WriteLine("Chouse 1 - Log In and 2 - Register!!");

            
        }


        






    }
}
