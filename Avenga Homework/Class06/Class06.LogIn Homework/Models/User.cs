using System;
using System.Collections.Generic;
using System.Text;

namespace Class06.LogIn_Homework.Models
{
    internal class User
    {
        public int ID { get; set; }

        public string UserName { get; set; }

        public string Password { get; set; }

        public string[] Messages { get; set; }

        public User()
        {

        }

        public User(int id, string username, string password, string[] messages)
        {
            ID = id;
            UserName = username;
            Password = password;
            Messages = messages ?? new string[0];
        }

    }
}
