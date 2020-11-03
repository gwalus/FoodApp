using FoodApp.Models;
using FoodApp.ViewModel.Commands;
using System.ComponentModel;
using System.Security.Cryptography;
using Xamarin.Forms;

namespace FoodApp.ViewModel
{
    public class RegisterVM : INotifyPropertyChanged
    {
        private string email;

        public string Email
        {
            get { return email; }
            set 
            {
                email = value;
                if (App.User != null)                
                    Email = App.User.Email;
            }
        }

        private string password;

        public string Password
        {
            get { return password; }
            set 
            {
                password = value;
                if (App.User != null)
                    Password = App.User.Password;
            }
        }

        private ImageSource image;

        public ImageSource Image
        {
            get { return image; }
            set { image = value; }
        }


        public CancelRegisterCommand CancelRegisterCommand { get; set; }

        public RegisterVM()
        {
            Image = ImageSource.FromResource("FoodApp.Assets.Icons.icon_user.png");
            CancelRegisterCommand = new CancelRegisterCommand(this);
        }

        public async void GoToLoginPage()
        {
            await App.Current.MainPage.Navigation.PopAsync();
        }


        public event PropertyChangedEventHandler PropertyChanged;
    }
}
