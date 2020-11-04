using System;
using System.Windows.Input;

namespace FoodApp.ViewModel.Commands
{
    public class GoToRegisterPageCommand : ICommand
    {
        LoginVM _viewModel;

        public GoToRegisterPageCommand(LoginVM viewModel)
        {
            _viewModel = viewModel;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            _viewModel.GoToRegisterPage();
        }

#pragma warning disable 67
        public event EventHandler CanExecuteChanged;
#pragma warning restore 67
    }
}
