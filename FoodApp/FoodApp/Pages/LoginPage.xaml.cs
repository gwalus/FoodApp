using FoodApp.Data;
using FoodApp.ViewModel;
using Microsoft.EntityFrameworkCore;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FoodApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        LoginVM viewModel;

        public LoginPage()
        {
            InitializeComponent();

            viewModel = new LoginVM();
            BindingContext = viewModel;
        }

        private async void TestButton_Clicked(object sender, EventArgs e)
        {
            using (var context = new FoodAppContext())
            {
                var test = await context.Users.SingleOrDefaultAsync(x => x.Id == 1);

                await DisplayAlert("Test", $"{test.Id}", "Ok");
                await DisplayAlert("Test", $"{test.Email}", "Ok");
                await DisplayAlert("Test", $"{test.PasswordHash}", "Ok");
                await DisplayAlert("Test", $"{test.PasswordSalt}", "Ok");
            }
        }
    }
}