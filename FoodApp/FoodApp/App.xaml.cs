using FoodApp.Dtos;
using Xamarin.Forms;

namespace FoodApp
{
    public partial class App : Application
    {
        public static UserForRegisterDto UserForRegisterDto { get; set; }

        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new LoginPage());

            UserForRegisterDto = new UserForRegisterDto();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
