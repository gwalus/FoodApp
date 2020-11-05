using FoodApp.Data;
using FoodApp.ViewModel.Commands;
using Microsoft.EntityFrameworkCore;
using System;
using System.ComponentModel;

namespace FoodApp.ViewModel
{
    public class MainVM : INotifyPropertyChanged
    {
        FoodAppContext _dbContext;

        private string email;

        public string Email
        {
            get { return email; }
            set { email = App.CurrentUser.Email; }
        }

        public TestingCommand TestingCommand { get; set; }
        DataRepository _repo;

        public MainVM()
        {
            TestingCommand = new TestingCommand(this);
            _repo = new DataRepository();
            _dbContext = new FoodAppContext();
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
