using FoodApp.Data;
using FoodApp.ViewModel.Commands;
using System.ComponentModel;

namespace FoodApp.ViewModel
{
    public class MainVM : INotifyPropertyChanged
    {
        private string email;

        public string Email
        {
            get { return email; }
            set { email = App.CurrentUser.Email; }
        }

        public TestingCommand TestingCommand { get; set; }

        FoodAppContext _dbContext;
        IDataRepository _repo;

        public MainVM(FoodAppContext context, IDataRepository repo)
        {
            _dbContext = context;
            _repo = repo;
            TestingCommand = new TestingCommand(this);
        }

#pragma warning disable 67
        public event PropertyChangedEventHandler PropertyChanged;
#pragma warning restore 67

        public void Testing()
        {
            //var posts = await _dbContext.Posts.ToListAsync();
        }
    }
}
