using System.Collections.Generic;

namespace EdamanService.Models
{
    public class Nutrients
    {
        public double ENERC_KCAL { get; set; }
        public double PROCNT { get; set; }
        public double FAT { get; set; }
        public double CHOCDF { get; set; }
        public double FIBTG { get; set; }
    }

    public class Food
    {
        public string foodId { get; set; }
        public string label { get; set; }
        public Nutrients nutrients { get; set; }
        public string category { get; set; }
        public string categoryLabel { get; set; }
        public double servingsPerContainer { get; set; }
        public string image { get; set; }
    }

    public class Parsed
    {
        public Food food { get; set; }
    }

    public class Qualifier
    {
        public string uri { get; set; }
        public string label { get; set; }
    }

    public class Qualified
    {
        public IList<Qualifier> qualifiers { get; set; }
        public double weight { get; set; }
    }

    public class Measure
    {
        public string uri { get; set; }
        public string label { get; set; }
        public double weight { get; set; }
        public IList<Qualified> qualified { get; set; }
    }

    public class Hint
    {
        public Food food { get; set; }
        public IList<Measure> measures { get; set; }
    }


    public class FoodResponse
    {
        public string text { get; set; }
        public IList<Parsed> parsed { get; set; }
        public IList<Hint> hints { get; set; }
    }
}
