using EdamanService.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EdamanService
{
    public interface IFoodRecipiesService
    {
        Task<IList<Hit>> GetRecipies(string name);
    }
}
