using AutoMapper;
using EdamanService;
using FoodApp.Data;
using FoodApp.Dtos;
using FoodApp.Models;
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

        private bool loading;

        public bool Loading
        {
            get { return loading; }
            set { loading = value; }
        }



        public UserLoginCommand UserLoginCommand { get; set; }
        public GoToRegisterPageCommand GoToRegisterPageCommand { get; set; }

        private readonly IUserService _userService;

        public LoginVM(IUserService userService)
        {
            _userService = userService;
            UserLoginCommand = new UserLoginCommand(this);
            GoToRegisterPageCommand = new GoToRegisterPageCommand(this);
            Image = ImageSource.FromResource("FoodApp.Assets.Icons.icon_food.png");
            User = new UserForLoginDto();

            //FoodInfoService foodInfoService = new FoodInfoService();
            //foodInfoService.GetFoodInfo("banana");
        }

#pragma warning disable 67
        public event PropertyChangedEventHandler PropertyChanged;
#pragma warning restore 67

        public async void Login()
        {
            var user = await _userService.Login(Email.ToLower(), Password);

            if (user != null)
            {
                var config = new MapperConfiguration(cfg => cfg.CreateMap<User, UserReturnedDto>());

                var mapper = new Mapper(config);
                var userLogin = mapper.Map<UserReturnedDto>(user);

                App.CurrentUser = userLogin;

                await App.Current.MainPage.DisplayAlert("Welcome in Food App", "Logged in successfully", "Ok");
                await App.Current.MainPage.Navigation.PushAsync(new MainPage());
            }
            else if (await App.Current.MainPage.DisplayAlert("Error", "Your email or password doesn't correctly!", "Create an account", "Let's try again"))
            {
                App.CurrentUser = null;
                await App.Current.MainPage.Navigation.PushAsync(new RegisterPage());
            }
        }

        public async void GoToRegisterPage()
        {
            App.CurrentUser = null;
            await App.Current.MainPage.Navigation.PushAsync(new RegisterPage());
        }
    }
}
