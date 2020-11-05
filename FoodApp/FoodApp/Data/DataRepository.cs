using FoodApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodApp.Data
{
    public class DataRepository : IDataRepository
    {
        FoodAppContext _dbContext;
        UserService _userService;

        public DataRepository()
        {
            _dbContext = new FoodAppContext();
            _userService = new UserService();
        }

        public async Task<bool> AddPost(Post post)
        {
            var user = await _userService.GetUser(App.CurrentUser.Email);
            post.UserId = user.Id;

            try
            {
                await _dbContext.Posts.AddAsync(post);
                await _dbContext.SaveChangesAsync();
                return true;
            }
            catch (Exception)
            {
                return false;
            }

        }

        public ICollection<Post> GetPosts(string email)
        {
            
            var user = _userService.GetUser(email);
            
            return  _dbContext.Posts.Where(u => u.UserId == user.Id).ToList();
        }
    }
}