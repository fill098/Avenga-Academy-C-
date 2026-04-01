using System;
using System.Collections.Generic;
using System.Text;

namespace Class06.Atm.Models
{
    internal class Customers
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int CardNumber { get; set; }
        private int _Pin { get; set; }
        private double _Balance { get; set; }

        public Customers(string firstName, string lastName, int cardNumber, int pin, double balance)
        {
            FirstName = firstName;
            LastName = lastName;
            CardNumber = cardNumber;
            _Pin = pin;
            _Balance = balance;
        }



        public bool ValidatePin(int pin)
        {

            return _Pin == pin;
        }


    }
}
