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
    }
}