using FoodApp.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace FoodApp.Data
{
    class UserService : IUserService
    {
        private readonly FoodAppContext _dbContext;

        public UserService()
        {
            _dbContext = new FoodAppContext();
        }

        public async Task<bool> CanLogin(User user)
        {
            var usr = await _dbContext.Users.SingleOrDefaultAsync(x => x.Email == user.Email);

            if (usr != null)
            {
                if (usr.Password == user.Password)
                    return true;
                return false;
            }
            else if (user.Email == "admin" && user.Password == "admin")
                return true; // do testowania
            return false;            
        }

        public async void Register(User user)
        {
            if (user != null)
                await _dbContext.AddAsync(user);
        }
    }
}
