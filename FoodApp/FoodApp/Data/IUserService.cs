using FoodApp.Dtos;
using FoodApp.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FoodApp.Data
{
    public interface IUserService
    {
        Task<bool> CanLogin(User user);
        Task<bool> Register(User user, string password);
    }
}
