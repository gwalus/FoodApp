using System;
using System.Windows.Input;

namespace FoodApp.ViewModel.Commands
{
    public class CancelRegisterCommand : ICommand
    {
        RegisterVM _viewModel;

        public CancelRegisterCommand(RegisterVM viewModel)
        {
            _viewModel = viewModel;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            _viewModel.GoToLoginPage();
        }

#pragma warning disable 67
        public event EventHandler CanExecuteChanged;
#pragma warning restore 67
    }
}
