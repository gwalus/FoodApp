﻿using System;
using System.Windows.Input;

namespace FoodApp.ViewModel.Commands
{
    public class SearchFoodCommand : ICommand
    {
        private readonly SearchFoodPageVM _viewModel;

        public SearchFoodCommand(SearchFoodPageVM viewModel)
        {
            _viewModel = viewModel;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            if (parameter != null)
                _viewModel.GetFoodInfo(parameter.ToString());
        }

#pragma warning disable 67
        public event EventHandler CanExecuteChanged;
#pragma warning restore 67
    }
}
