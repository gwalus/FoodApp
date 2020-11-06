using System;
using Xamarin.Forms;

namespace FoodApp.Models
{
    public class Post
    {
        public int Id { get; set; }
        public string MealType { get; set; }
        public string MealName { get; set; }
        public int  Quantity { get; set; }
        public int Weight { get; set; }
        public int Rate { get; set; }
        public DateTime PostAdded { get; set; }
        public virtual User User { get; set; }
        public int UserId { get; set; }
    }
}
