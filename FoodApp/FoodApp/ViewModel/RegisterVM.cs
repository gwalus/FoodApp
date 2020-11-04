using AutoMapper;
using FoodApp.Data;
using FoodApp.Dtos;
using FoodApp.Models;
using FoodApp.ViewModel.Commands;
using System.ComponentModel;
using Xamarin.Forms;

namespace FoodApp.ViewModel
{
    public class RegisterVM : INotifyPropertyChanged
    {
        public UserForRegisterDto User { get; set; }

        private string email;

        public string Email
        {
            get { return email; }
            set 
            {
                email = value;
                if (App.UserForLoginDto != null)
                    Email = App.UserForLoginDto.Email;                 
                else
                {
                    User = new UserForRegisterDto()
                    {
                        Email = Email,
                        Password = Password,
                        PasswordConfirm = PasswordConfirm
                    };
                }
            }
        }

        private string password;

        public string Password
        {
            get { return password; }
            set 
            {
                password = value;
                if (App.UserForLoginDto != null)
                    Password = App.UserForLoginDto.Password;
                else
                {
                    User = new UserForRegisterDto()
                    {
                        Email = Email,
                        Password = Password,
                        PasswordConfirm = PasswordConfirm
                    };
                }
            }
        }

        private string passwordConfirm;

        public string PasswordConfirm
        {
            get { return passwordConfirm; }
            set
            {
                passwordConfirm = value;
                User = new UserForRegisterDto()
                {
                    Email = Email,
                    Password = Password,
                    PasswordConfirm = PasswordConfirm
                };
            }
        }

        private ImageSource image;

        public ImageSource Image
        {
            get { return image; }
            set { image = value; }
        }


        public CancelRegisterCommand CancelRegisterCommand { get; set; }
        public UserRegisterCommand UserRegisterCommand { get; set; }
        private UserService _userService { get; set; }

        public RegisterVM()
        {
            Image = ImageSource.FromResource("FoodApp.Assets.Icons.icon_user.png");
            CancelRegisterCommand = new CancelRegisterCommand(this);
            UserRegisterCommand = new UserRegisterCommand(this);
            User = new UserForRegisterDto();
            _userService = new UserService();
        }

        public async void Register(UserForRegisterDto userForRegisterDto)
        {
            userForRegisterDto.Email.ToLower();

            if(await _userService.UserExists(userForRegisterDto.Email))
            {
                await App.Current.MainPage.DisplayAlert("User already exists", "Please confirm an other email to register new account", "Ok");
            }
            else
            {
                var config = new MapperConfiguration(cfg => cfg.CreateMap<UserForRegisterDto, User>());

                var mapper = new Mapper(config);
                var userToCreate = mapper.Map<User>(userForRegisterDto);
                // mapowanie na User'a z właściwościami passwordHash i passwordSalt

                if (await _userService.Register(userToCreate, userForRegisterDto.Password)) // tworzymy nowego użytkownika z podanym hasłem w formularzu
                {
                    await App.Current.MainPage.DisplayAlert("Success", "User has been created successfully!", "Log in");
                    await App.Current.MainPage.Navigation.PushAsync(new LoginPage());
                }
                else
                    await App.Current.MainPage.DisplayAlert("Failed", "Something went wrong", "Let's try again");
            }
        }

        public async void GoToLoginPage()
        {
            await App.Current.MainPage.Navigation.PopAsync();
        }


#pragma warning disable 67
        public event PropertyChangedEventHandler PropertyChanged;
#pragma warning restore 67
    }
}
