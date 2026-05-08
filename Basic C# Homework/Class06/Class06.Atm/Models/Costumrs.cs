using Class06.HelperMethod;
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
        private int _Balance { get; set; }

        public Customers(string firstName, string lastName, int cardNumber, int pin, int balance)
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


        public int GetBalance()
        {

            return _Balance;
        }


        public void PrintBalance()
        {
            Console.WriteLine($"Your balance is: {GetBalance()}");
        }



        public void Withdraw(int amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine("Amount must be greater than zero!");
                
            }

            if (amount > _Balance)
            {
                Console.WriteLine("You cannot withdraw more than your balance!");
              
            }

            _Balance -= amount;  
            Console.WriteLine($"Your new balance is: {_Balance}");
            
        }


        public void Deposit(int amount)
        {

            if (_Balance == 0) 
            {
                Console.WriteLine("You can not deposit 0 dollars");
            }
            else
            {
                _Balance += amount;
                Console.WriteLine($"Your new balance is: {_Balance}");
            }

       

        }

 

        public static Customers FindAtmUser(Customers[] atmCustomers, int cardNumber, int cardPin)
        {
            foreach (Customers user in atmCustomers)
            {
                if (user.CardNumber == cardNumber && user.ValidatePin(cardPin))
                {
                    return user;
                }
            }
            return null;
        }

        






    }
}
