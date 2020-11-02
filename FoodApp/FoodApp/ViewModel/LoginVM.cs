using FoodApp.Data;
using FoodApp.Models;
using System.ComponentModel;
using Xamarin.Forms;

namespace FoodApp.ViewModel
{
    public class LoginVM : INotifyPropertyChanged
    {
        public User User { get; set; }
        public ImageSource Image { get; set; }
        UserService _userService;

        private string email;

        public string Email
        {
            get { return email; }
            set
            {
                email = value;
                User = new User()
                {
                    Email = Email,
                    Password = Password
                };
            }
        }

        private string password;


        public string Password
        {
            get { return password; }
            set
            {
                password = value;
                User = new User()
                {
                    Email = Email,
                    Password = Password
                };
            }
        }


        public LoginCommand LoginCommand { get; set; }

        public LoginVM()
        {
            LoginCommand = new LoginCommand(this);
            Image = ImageSource.FromResource("FoodApp.Assets.Icons.icon_food.png");
            User = new User();
            _userService = new UserService();
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public async void Login()
        {
            if (await _userService.CanLogin(User))
            {
                App.User = User;
                await App.Current.MainPage.Navigation.PushAsync(new MainPage());
            }
            else
                await App.Current.MainPage.DisplayAlert("Error", "Your email or password doesn't correctly!", "Let's try again");
        }
    }
}
