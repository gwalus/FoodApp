using EdamanService.Models;
using System.Threading.Tasks;

namespace EdamanService
{
    public interface IFoodRecipiesService
    {
        Task<RecipeResponse> GetRecipe(string name);
    }
}
