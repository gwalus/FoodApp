using FoodApp.Data;
using FoodApp.Models;
using FoodApp.ViewModel.Commands;
using System.Collections.Generic;
using System.ComponentModel;

namespace FoodApp.ViewModel
{
    public class NewPostVM : INotifyPropertyChanged
    {
        public Post Post { get; set; }

        List<string> mealType;
        public List<string> MealType
        {
            get { return mealType; }
            set
            {
                if (mealType != value)
                {
                    mealType = value;
                }
            }
        }

        private object mealTypeSelected;

        public object MealTypeSelected
        {
            get { return mealTypeSelected; }
            set
            {
                mealTypeSelected = value;
                if(MealTypeSelected != null)
                    Post.MealType = MealTypeSelected.ToString();
            }
        }


        private string mealName;

        public string MealName
        {
            get { return mealName; }
            set
            {
                mealName = value;
                Post.MealName = MealName;
            }
        }

        private List<int> quantity;
        public List<int> Quantity
        {
            get { return quantity; }
            set
            {
                if (quantity != value)
                {
                    quantity = value;
                }
            }
        }

        private object quantitySelected;

        public object QuantitySelected
        {
            get { return quantitySelected; }
            set
            {
                quantitySelected = null;
                if (QuantitySelected != null)
                    Post.Quantity = int.Parse(QuantitySelected.ToString());
            }
        }

        private string weight;

        public string Weight
        {
            get { return weight; }
            set
            {
                weight = value;
                if(!string.IsNullOrWhiteSpace(Weight))
                    Post.Weight = int.Parse(Weight);
            }
        }

        List<int> rate;
        public List<int> Rate
        {
            get { return rate; }
            set
            {
                if (rate != value)
                {
                    rate = value;
                }
            }
        }

        private object rateSelected;

        public object RateSelected
        {
            get { return rateSelected; }
            set
            {
                rateSelected = value;
                if(RateSelected != null)
                    Post.Rate = int.Parse(RateSelected.ToString());
            }
        }

        public AddNewPostCommand AddNewPostCommand { get; set; }
        private DataRepository _repo;

        public NewPostVM()
        {
            MealType = new List<string> { "Breakfast", "Lunch", "Dinner", "Dessert", "Other" };
            Quantity = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };
            Rate = new List<int> { 1, 2, 3, 4, 5 };
            Post = new Post();
            AddNewPostCommand = new AddNewPostCommand(this);
            _repo = new DataRepository();
        }

        public async void AddNewPost(Post post)
        {
            if(await _repo.AddPost(post))
            {
                await App.Current.MainPage.DisplayAlert("Success", "New post has been added", "Ok");
                ClearPropertyBindings();
            }
            else await App.Current.MainPage.DisplayAlert("Failed", "Something went wrong", "Ok");
        }

        private void ClearPropertyBindings()
        {
            Post = new Post();
            MealTypeSelected = null;
            MealName = string.Empty;
            QuantitySelected = null;
            Weight = string.Empty;
            RateSelected = null;
        }

#pragma warning disable 67
        public event PropertyChangedEventHandler PropertyChanged;
#pragma warning restore 67
    }
}
