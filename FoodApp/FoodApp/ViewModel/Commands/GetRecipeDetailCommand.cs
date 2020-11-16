using EdamanService.Models;
using System;
using System.Collections.Generic;
using System.Text;
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

        public event EventHandler CanExecuteChanged;

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
    }
}
