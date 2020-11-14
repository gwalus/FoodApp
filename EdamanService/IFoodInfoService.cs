using EdamanService.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EdamanService
{
    public interface IFoodInfoService
    {
        Task<IList<Parsed>> GetFoodInfo(string name);
    }
}
