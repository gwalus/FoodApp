using System;
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

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            if (parameter != null)
                _viewModel.GetRecipies(parameter.ToString());
        }

#pragma warning disable 67
        public event EventHandler CanExecuteChanged;
#pragma warning restore 67
    }
}
