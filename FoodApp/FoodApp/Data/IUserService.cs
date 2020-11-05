using FoodApp.Models;
using System.Threading.Tasks;

namespace FoodApp.Data
{
    public interface IUserService
    {
        Task<User> Login(string email, string password);
        Task<bool> Register(User user, string password);
        Task<bool> UserExists(string email);
        Task<User> GetUser(string email);
    }
}
