using FoodApp.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography;

namespace FoodApp.Data
{
    public class UserService : IUserService
    {
        private readonly FoodAppContext _dbContext;

        public UserService()
        {
            _dbContext = new FoodAppContext();
        }

        public Task<bool> CanLogin(User user)
        {
            throw new NotImplementedException();
        }

        //public async Task<bool> CanLogin(User user)
        //{
        //    //var usr = await _dbContext.Users.SingleOrDefaultAsync(x => x.Email == user.Email);

        //    //if (usr != null)
        //    //{
        //    //    if (usr.Password == user.Password)
        //    //        return true;
        //    //    return false;
        //    //}
        //    //else if (user.Email == "admin" && user.Password == "admin")
        //    //    return true; // do testowania
        //    //return false;  

        //    throw NotImplementedException;
        //}

        public async Task<bool> Register(User user, string password)
        {
            byte[] passwordHash, passwordSalt;
            CreatePasswordHash(password, out passwordHash, out passwordSalt);

            user.PasswordHash = passwordHash;
            user.PasswordSalt = passwordSalt;

            try
            {
                await _dbContext.AddAsync(user);
                await _dbContext.SaveChangesAsync();

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        private void CreatePasswordHash(string password, out byte[] passwordHash, out byte[] passwordSalt)
        {
            using (var hmac = new HMACSHA512())
            {
                passwordSalt = hmac.Key;
                passwordHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(password));
            }
        }
    }
}
