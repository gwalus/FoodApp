using FoodApp.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FoodApp.Data
{
    interface IDataRepository
    {
        Task<bool> AddPost(Post post);
        ICollection<Post> GetPosts(string email);
    }
}
