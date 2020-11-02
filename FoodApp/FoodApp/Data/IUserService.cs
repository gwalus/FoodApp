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
        void Register(User user);
    }
}
