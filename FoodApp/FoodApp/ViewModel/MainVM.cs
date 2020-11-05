using FoodApp.Data;
using FoodApp.ViewModel.Commands;
using System;
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
        DataRepository _repo;

        public MainVM()
        {
            TestingCommand = new TestingCommand(this);
            _repo = new DataRepository();
        }

#pragma warning disable 67
        public event PropertyChangedEventHandler PropertyChanged;
#pragma warning restore 67

        public void Testing()
        {
            //_repo.GetPosts();
        }
    }
}
