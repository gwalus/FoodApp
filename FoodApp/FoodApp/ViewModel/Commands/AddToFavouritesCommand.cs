using System;
using System.Windows.Input;

namespace FoodApp.ViewModel.Commands
{
    public class AddToFavouritesCommand : ICommand
    {
        private readonly RecipeDetailedPageVM _viewModel;

        public AddToFavouritesCommand(RecipeDetailedPageVM viewModel)
        {
            _viewModel = viewModel;
        }
        
        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            _viewModel.AddToFavourite();
        }
#pragma warning disable 67
        public event EventHandler CanExecuteChanged;
#pragma warning restore 67
    }
}
