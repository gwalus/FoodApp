using FoodApp.Models;
using System;
using System.Windows.Input;

namespace FoodApp.ViewModel.Commands
{
    public class AddNewPostCommand : ICommand
    {
        NewPostVM _viewModel;

        public AddNewPostCommand(NewPostVM viewModel)
        {
            _viewModel = viewModel;
        }

        public bool CanExecute(object parameter)
        {
            var post = (Post)parameter;

            return post != null;
        }

        public void Execute(object parameter)
        {
            var post = (Post)parameter;
            _viewModel.AddNewPost(post);
        }

#pragma warning disable 67
        public event EventHandler CanExecuteChanged;
#pragma warning restore 67
    }
}
