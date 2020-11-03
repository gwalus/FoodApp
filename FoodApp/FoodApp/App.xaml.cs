using FoodApp.Dtos;
using Xamarin.Forms;

namespace FoodApp
{
    public partial class App : Application
    {
        public static UserForLoginDto UserForLoginDto { get; set; }

        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new LoginPage());

            UserForLoginDto = new UserForLoginDto();
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
