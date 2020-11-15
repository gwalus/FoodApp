using EdamanService.Models;
using RestSharp;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EdamanService
{
    public class FoodInfoService : IFoodInfoService
    {
        static string app_id = "540df23f";
        static string app_key = "d4f4f6013c394eafdabbec657ac81436";

        public async Task<IList<Parsed>> GetFoodInfo(string name)
        {
            var client = new RestClient("https://api.edamam.com/api/food-database/v2/parser");

            var request = new RestRequest()
                .AddParameter(nameof(app_id), app_id)
                .AddParameter(nameof(app_key), app_key)
                .AddParameter("ingr", name);

            var response = await client.ExecuteAsync<FoodResponse>(request);

            if (response.IsSuccessful)
                return response.Data.Parsed;
            return null;
        }
    }
}
