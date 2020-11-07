using FoodApp.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace FoodApp.Data
{
    public class DataRepository : IDataRepository
    {
        FoodAppContext _dbContext;
        IUserService _userService;

        public DataRepository()
        {
            _dbContext = DependencyService.Get<FoodAppContext>();
            _userService = DependencyService.Get<IUserService>();
        }

        public async Task<bool> AddPost(Post post)
        {
            var user = await _userService.GetUser(App.CurrentUser.Id);
            post.UserId = user.Id;
            post.PostAdded = DateTime.Today;

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

        public async Task<ICollection<Post>> GetPosts(int id)
        {   
            return await _dbContext.Posts.Where(u => u.UserId == id).ToListAsync();
        }
    }
}