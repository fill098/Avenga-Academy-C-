using System;
using System.Collections.Generic;
using System.Text;

namespace Class_UserRegister.Models
{
    public class User
    {

        public int Id { get; set; }
        public string UsreName { get; set; }

        public string Password { get; set; }

        public User(int)
        {
                
        }
    }
}
