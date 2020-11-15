using EdamanService;
using EdamanService.Models;
using FoodApp.ViewModel.Commands;
using System.ComponentModel;
using System.Linq;

namespace FoodApp.ViewModel
{
    public class SearchFoodPageVM : INotifyPropertyChanged
    {
        private readonly IFoodInfoService _foodInfoService;

        private Food food;

        public Food Food
        {
            get { return food; }
            set
            {
                food = value;
                OnPropertyChanged("Food");
            }
        }

        private bool infoVisible = false;

        public bool InfoVisible
        {
            get { return infoVisible; }
            set
            {
                infoVisible = value;
                OnPropertyChanged("InfoVisible");
            }
        }

        private bool notFoundVisible = false;

        public bool NotFoundVisible
        {
            get { return notFoundVisible; }
            set
            {
                notFoundVisible = value;
                OnPropertyChanged("NotFoundVisible");
            }
        }

        public SearchFoodCommand SearchFoodCommand { get; set; }

        public SearchFoodPageVM(IFoodInfoService foodInfoService)
        {
            SearchFoodCommand = new SearchFoodCommand(this);
            _foodInfoService = foodInfoService;
        }

        public async void GetFoodInfo(string name)
        {
            var infoAboutFood = await _foodInfoService.GetFoodInfo(name);

            if (infoAboutFood.Count != 0)
            {
                var food = infoAboutFood.FirstOrDefault();

                if (food.Food.Image == null)
                    food.Food.Image = "question_icon.png";

                Food = food.Food;
                InfoVisible = true;
                NotFoundVisible = false;
            }
            else
            {
                InfoVisible = false;
                NotFoundVisible = true;
            }
        }

        public void OnAppering()
        {
            InfoVisible = false;
            NotFoundVisible = false;
        }

        private void OnPropertyChanged(string memberName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(memberName));
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
