using EdamanService;
using EdamanService.Models;
using FoodApp.Pages;
using FoodApp.ViewModel.Commands;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace FoodApp.ViewModel
{
    public class SearchRecipiesPageVM : INotifyPropertyChanged
    {
        private readonly IFoodRecipiesService _foodRecipiesService;

        public SearchRecipiesCommand SearchRecipiesCommand { get; set; }
        public GetRecipeDetailCommand GetRecipeDetailCommand { get; set; }
        private IList<Hit> recipies;

        public event PropertyChangedEventHandler PropertyChanged;

        public IList<Hit> Recipies
        {
            get { return recipies; }
            set 
            {
                recipies = value;
                OnPropertyChanged("Recipies");
            }
        }

        public async void GoToRecipeDetailedPage(Recipe recipe)
        {
            await App.Current.MainPage.Navigation.PushAsync(new RecipeDetailedPage(recipe));
        }

        public SearchRecipiesPageVM(IFoodRecipiesService foodRecipiesService)
        {
            SearchRecipiesCommand = new SearchRecipiesCommand(this);
            GetRecipeDetailCommand = new GetRecipeDetailCommand(this);
            _foodRecipiesService = foodRecipiesService;
        }

        public async void GetRecipies(string recipeName)
        {
            var recipies = await _foodRecipiesService.GetRecipies(recipeName);

            Recipies = recipies.ToList();            
        }

        private void OnPropertyChanged(string memberName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(memberName));
        }
    }
}
