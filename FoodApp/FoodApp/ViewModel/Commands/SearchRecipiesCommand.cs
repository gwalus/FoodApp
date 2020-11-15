using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace FoodApp.ViewModel.Commands
{
    public class SearchRecipiesCommand : ICommand
    {
        private readonly SearchRecipiesPageVM _viewModel;

        public SearchRecipiesCommand(SearchRecipiesPageVM viewModel)
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
                _viewModel.GetRecipies(parameter.ToString());
        }
    }
}
