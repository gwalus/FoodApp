using System.ComponentModel;

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

#pragma warning disable 67
        public event PropertyChangedEventHandler PropertyChanged;
#pragma warning restore 67
    }
}
