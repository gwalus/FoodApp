using EdamanService.Models;
using System;
using System.Windows.Input;

namespace FoodApp.ViewModel.Commands
{
    public class GetRecipeDetailCommand : ICommand
    {
        private readonly SearchRecipiesPageVM _viewModel;

        public GetRecipeDetailCommand(SearchRecipiesPageVM viewModel)
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
            {
                var recipe = parameter as Recipe;
                _viewModel.GoToRecipeDetailedPage(recipe);
            }
        }

#pragma warning disable 67
        public event EventHandler CanExecuteChanged;
#pragma warning restore 67
    }
}
