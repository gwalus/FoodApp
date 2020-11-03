using AutoMapper;
using FoodApp.Data;
using FoodApp.Dtos;
using FoodApp.Models;
using FoodApp.ViewModel.Commands;
using System.ComponentModel;
using System.Security.Cryptography;
using System.Threading.Tasks;
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
                //if (App.UserForRegisterDto != null)                
                //    Email = App.UserForRegisterDto.Email;
                User = new UserForRegisterDto()
                {
                    Email = Email,
                    Password = Password,
                    PasswordConfirm = PasswordConfirm
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
                //if (App.UserForRegisterDto != null)
                //    Password = App.UserForRegisterDto.Password;
                User = new UserForRegisterDto()
                {
                    Email = Email,
                    Password = Password,
                    PasswordConfirm = PasswordConfirm
                };
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
        UserService UserService { get; set; }

        public RegisterVM()
        {
            Image = ImageSource.FromResource("FoodApp.Assets.Icons.icon_user.png");
            CancelRegisterCommand = new CancelRegisterCommand(this);
            UserRegisterCommand = new UserRegisterCommand(this);
            User = new UserForRegisterDto();
            UserService = new UserService();
        }

        public void Register(UserForRegisterDto userForRegisterDto)
        {
            userForRegisterDto.Email.ToLower();

            // sprawdzenie, czy użytkownik taki istnieje ?!

            var config = new MapperConfiguration(cfg => cfg.CreateMap<UserForRegisterDto, User>());

            var mapper = new Mapper(config);
            var userToCreate = mapper.Map<User>(userForRegisterDto);

            //var userToCreate = _mapper.Map<User>(userForRegisterDto);

            // mapowanie na User'a z właściwościami passwordHash i passwordSalt

            //var createdUser = 
            UserService.Register(userToCreate, userForRegisterDto.Password);
            // tworzymy nowego użytkownika z podanym hasłem w formularzu

            //var config2 = new MapperConfiguration(cfg => cfg.CreateMap<UserReturnedDto, User>());
            //var mapper2 = new Mapper(config2);

            //var userToReturn = mapper2.Map<UserReturnedDto>(createdUser);
            //// zwracamy użytkownika tylko z emailem, bez hasła

            //return userToReturn;
        }

        public async void GoToLoginPage()
        {
            await App.Current.MainPage.Navigation.PopAsync();
        }


        public event PropertyChangedEventHandler PropertyChanged;
    }
}
