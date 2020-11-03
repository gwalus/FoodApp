using System;
using System.Collections.Generic;
using System.Text;
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

        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            _viewModel.GoToRegisterPage();
        }
    }
}
