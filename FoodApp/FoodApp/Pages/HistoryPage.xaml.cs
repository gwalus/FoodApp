﻿using FoodApp.Data;
using FoodApp.ViewModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FoodApp.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HistoryPage : ContentPage
    {
        HistoryPageVM _viewModel;

        public HistoryPage()
        {
            InitializeComponent();
            _viewModel = new HistoryPageVM();
            BindingContext = _viewModel;
        }
    }
}