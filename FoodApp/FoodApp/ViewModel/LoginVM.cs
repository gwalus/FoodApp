﻿using FoodApp.Data;
using FoodApp.Dtos;
using FoodApp.Pages;
using FoodApp.ViewModel.Commands;
using System.ComponentModel;
using Xamarin.Forms;

namespace FoodApp.ViewModel
{
    public class LoginVM : INotifyPropertyChanged
    {
        public UserForLoginDto User { get; set; }
        public ImageSource Image { get; set; }
        private readonly UserService _userService;

        private string email;

        public string Email
        {
            get { return email; }
            set
            {
                email = value;
                User = new UserForLoginDto()
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
                User = new UserForLoginDto()
                {
                    Email = Email,
                    Password = Password
                };
            }
        }


        public UserLoginCommand UserLoginCommand { get; set; }
        public GoToRegisterPageCommand GoToRegisterPageCommand { get; set; }

        public LoginVM()
        {
            UserLoginCommand = new UserLoginCommand(this);
            GoToRegisterPageCommand = new GoToRegisterPageCommand(this);
            Image = ImageSource.FromResource("FoodApp.Assets.Icons.icon_food.png");
            User = new UserForLoginDto();
            _userService = new UserService();
        }

#pragma warning disable 67
        public event PropertyChangedEventHandler PropertyChanged;
#pragma warning restore 67

        public async void Login()
        {
            var user = await _userService.Login(Email.ToLower(), Password);

            if (user != null)
            {
                App.UserForLoginDto = User;
                await App.Current.MainPage.DisplayAlert("Welcome in Food App", "Logged in successfully", "Ok");
                await App.Current.MainPage.Navigation.PushAsync(new MainPage());
            }
            else if (await App.Current.MainPage.DisplayAlert("Error", "Your email or password doesn't correctly!", "Create an account", "Let's try again"))
                await App.Current.MainPage.Navigation.PushAsync(new RegisterPage());
        }

        public async void GoToRegisterPage()
        {
            App.UserForLoginDto = null;
            await App.Current.MainPage.Navigation.PushAsync(new RegisterPage());
        }
    }
}
