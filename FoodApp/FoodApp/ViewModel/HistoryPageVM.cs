using FoodApp.Data;
using FoodApp.Models;
using FoodApp.Pages;
using System.Collections.Generic;
using System.ComponentModel;

namespace FoodApp.ViewModel
{
    public class HistoryPageVM : INotifyPropertyChanged
    {
        private ICollection<Post> posts;

        public ICollection<Post> Posts
        {
            get { return posts; }
            set { posts = value; }
        }

        DataRepository _repo;

        public HistoryPageVM()
        {
            _repo = new DataRepository();
            LoadPosts();
        }

        private void LoadPosts()
        {
            Posts = _repo.GetPosts(App.CurrentUser.Email);
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
