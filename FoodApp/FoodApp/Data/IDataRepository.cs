using FoodApp.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FoodApp.Data
{
    interface IDataRepository
    {
        Task<bool> AddPost(Post post);
        Task<ICollection<Post>> GetPosts(int id);
    }
}
