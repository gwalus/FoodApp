using FoodApp.Data;
using FoodApp.Models;
using FoodApp.Pages;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using Xamarin.Forms.Internals;

namespace FoodApp.ViewModel
{
    public class HistoryPageVM : INotifyPropertyChanged
    {
        private List<Post> posts;

        public List<Post> Posts
        {
            get { return posts; }
            set 
            {
                posts = value;
            }
        }


        DataRepository _repo;

        public HistoryPageVM()
        {
            _repo = new DataRepository();
            Posts = new List<Post>();
        }

        public async void LoadPosts()
        {
            var posts = await _repo.GetPosts(App.CurrentUser.Id);
            Posts = posts.ToList();
        }
#pragma warning disable 67
        public event PropertyChangedEventHandler PropertyChanged;
#pragma warning restore 67
    }
}
