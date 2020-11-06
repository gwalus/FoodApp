using FoodApp.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace FoodApp.Helpers
{
    public class PostGroup : ObservableCollection<Post>
    {
        public DateTime PostAdded { get; set; }

        public PostGroup()
        {

        }

        public PostGroup(DateTime date)
        {
            PostAdded = date;
        }

        public PostGroup(DateTime date, IEnumerable<Post> source)
        : base(source)
        {
            PostAdded = date;
        }
    }
}
