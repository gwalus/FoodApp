using EdamanService.Models;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EdamanService
{
    public class FoodRecipiesService : IFoodRecipiesService
    {
        static string app_id = "b7205918";
        static string app_key = "d26c3dd8a6704b67c165ae41e3656f6f";

        public async Task<RecipeResponse> GetRecipe(string name)
        {
            var client = new RestClient("https://api.edamam.com/search");

            var request = new RestRequest()
                .AddParameter(nameof(app_id), app_id)
                .AddParameter(nameof(app_key), app_key)
                .AddParameter("q", name);

            var response = await client.ExecuteAsync<RecipeResponse>(request);

            if (response.IsSuccessful)
                return response.Data;
            return null;
        }
    }
}
