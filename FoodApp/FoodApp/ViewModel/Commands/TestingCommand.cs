using System;
using System.Windows.Input;

namespace FoodApp.ViewModel.Commands
{
    public class TestingCommand : ICommand
    {
        MainVM _viewModel;
        public TestingCommand(MainVM viewModel)
        {
            _viewModel = viewModel;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            _viewModel.Testing();
        }
#pragma warning disable 67
        public event EventHandler CanExecuteChanged;
#pragma warning restore 67
    }
}
