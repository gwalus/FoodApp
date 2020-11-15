using EdamanService;
using EdamanService.Models;
using FoodApp.ViewModel.Commands;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace FoodApp.ViewModel
{
    public class SearchRecipiesPageVM : INotifyPropertyChanged
    {
        private readonly IFoodRecipiesService _foodRecipiesService;

        public SearchRecipiesCommand SearchRecipiesCommand { get; set; }
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


        public SearchRecipiesPageVM(IFoodRecipiesService foodRecipiesService)
        {
            SearchRecipiesCommand = new SearchRecipiesCommand(this);
            _foodRecipiesService = foodRecipiesService;
        }

        public async void GetRecipies(string recipeName)
        {
            var recipies = await _foodRecipiesService.GetRecipies(recipeName);

            //recipies.Take(5);

            Recipies = recipies.Take(5).ToList();
        }

        private void OnPropertyChanged(string memberName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(memberName));
        }
    }
}
