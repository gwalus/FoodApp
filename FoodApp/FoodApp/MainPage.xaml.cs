using FoodApp.ViewModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace FoodApp
{
    public partial class MainPage : ContentPage
    {
        MainVM _viewModel;

        public MainPage()
        {
            InitializeComponent();

            _viewModel = new MainVM();
            BindingContext = _viewModel;
        }
    }
}
