using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace FoodApp.ViewModel
{
    public class MainVM : INotifyPropertyChanged
    {
        private string email;

        public string Email
        {
            get { return email; }
            set { email = App.UserForLoginDto.Email; }
        }

        public MainVM()
        {

        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
