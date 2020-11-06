using FoodApp.Data;
using FoodApp.Helpers;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;

namespace FoodApp.ViewModel
{
    public class HistoryPageVM : INotifyPropertyChanged
    {
        public ObservableCollection<PostGroup> Posts { get; set; } = new ObservableCollection<PostGroup>();

        DataRepository _repo;

        public HistoryPageVM()
        {
            _repo = new DataRepository();
        }

        public async void LoadPosts()
        {
            Posts.Clear();

            var posts = await _repo.GetPosts(App.CurrentUser.Id);
            var dates = posts.Select(x => x.PostAdded).Distinct().ToList();

            foreach (var date in dates)
            {
                var postsByDate = posts.Where(x => x.PostAdded == date).ToList();


                var postGroup = new PostGroup(date, postsByDate);
                Posts.Add(postGroup);
            }            
        }

#pragma warning disable 67
        public event PropertyChangedEventHandler PropertyChanged;
#pragma warning restore 67
    }
}
