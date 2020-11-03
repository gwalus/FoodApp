using System;
using System.Collections.Generic;
using System.Text;

namespace FoodApp.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Email { get; set; }
        //public string Password { get; set; }

        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }
    }
}
