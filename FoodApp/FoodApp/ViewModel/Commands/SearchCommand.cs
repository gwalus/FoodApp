using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace FoodApp.ViewModel.Commands
{
    public class SearchCommand : ICommand
    {
        private readonly SearchPageVM _viewModel;

        public SearchCommand(SearchPageVM viewModel)
        {
            _viewModel = viewModel;
        }

        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            if (parameter != null)
                _viewModel.GetFoodInfo(parameter.ToString());
        }
    }
}
