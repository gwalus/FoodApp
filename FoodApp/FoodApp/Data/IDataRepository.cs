using FoodApp.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FoodApp.Data
{
    public interface IDataRepository
    {
        Task<bool> AddPost(Post post);
        Task<ICollection<Post>> GetPosts(int id);
    }
}
