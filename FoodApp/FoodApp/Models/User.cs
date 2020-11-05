using System.Collections.Generic;

namespace FoodApp.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Email { get; set; }

        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }
        public virtual ICollection<Post> Posts { get; set; }
    }
}
