using FoodApp.Data;
using FoodApp.Models;
using FoodApp.ViewModel.Commands;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading.Tasks;
using Xamarin.Forms;

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

        private string mealTypeSelected;

        public string MealTypeSelected
        {
            get { return mealTypeSelected; }
            set
            {
                mealTypeSelected = value;
                Post.MealType = MealTypeSelected;
                //Post = new Post()
                //{
                //    MealType = MealTypeSelected,
                //    //MealName = MealName,
                //    //Count = CountSelected,
                //    //Weight = double.Parse(Weight.ToString()),
                //    //Scale = int.Parse(ScaleSelected.ToString())
                //};
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
                //Post = new Post()
                //{
                //    //MealType = MealTypeSelected.ToString(),
                //    MealName = MealName
                //    //Count = int.Parse(CountSelected.ToString()),
                //    //Weight = double.Parse(Weight.ToString()),
                //    //Scale = int.Parse(ScaleSelected.ToString())
                //};
            }
        }

        List<int> count;
        public List<int> Count
        {
            get { return count; }
            set
            {
                if (count != value)
                {
                    count = value;
                }
            }
        }

        private int countSelected;

        public int CountSelected
        {
            get { return countSelected; }
            set
            {
                countSelected = value;
                Post.Count = CountSelected;
                //Post = new Post()
                //{
                //    //MealType = MealTypeSelected.ToString(),
                //    //MealName = MealName,
                //    Count = CountSelected
                //    //Weight = double.Parse(Weight.ToString()),
                //    //Scale = int.Parse(ScaleSelected.ToString())
                //};
            }
        }

        private string weight;

        public string Weight
        {
            get { return weight; }
            set
            {
                weight = value;
                Post.Weight = int.Parse(Weight);
                //Post = new Post()
                //{
                //    //MealType = MealTypeSelected.ToString(),
                //    //MealName = MealName,
                //    //Count = int.Parse(CountSelected.ToString()),
                //    Weight = double.Parse(Weight.ToString())
                //    //Scale = int.Parse(ScaleSelected.ToString())
                //};
            }
        }

        List<int> scale;
        public List<int> Scale
        {
            get { return scale; }
            set
            {
                if (scale != value)
                {
                    scale = value;
                }
            }
        }

        private int scaleSelected;

        public int ScaleSelected
        {
            get { return scaleSelected; }
            set
            {
                scaleSelected = value;
                Post.Scale = ScaleSelected;
                //Post = new Post()
                //{
                //    //MealType = MealTypeSelected.ToString(),
                //    //MealName = MealName,
                //    //Count = int.Parse(CountSelected.ToString()),
                //    //Weight = double.Parse(Weight.ToString()),
                //    Scale = ScaleSelected
                //};
            }
        }

        public AddNewPostCommand AddNewPostCommand { get; set; }
        private DataRepository _repo;

        public NewPostVM()
        {
            MealType = new List<string> { "Breakfast", "Lunch", "Dinner", "Dessert", "Other" };
            Count = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };
            Scale = new List<int> { 1, 2, 3, 4, 5 };
            Post = new Post();
            AddNewPostCommand = new AddNewPostCommand(this);
            _repo = new DataRepository();
        }

        public async void AddNewPost(Post post)
        {
            if(await _repo.AddPost(post))
                await App.Current.MainPage.DisplayAlert("Success", "New post has been added", "Ok");
            else await App.Current.MainPage.DisplayAlert("Failed", "Something went wrong", "Ok");
        }

#pragma warning disable 67
        public event PropertyChangedEventHandler PropertyChanged;
#pragma warning restore 67
    }
}
