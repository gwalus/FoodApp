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
        public string FoodId { get; set; }
        public string Label { get; set; }
        public Nutrients Nutrients { get; set; }
        public string Category { get; set; }
        public string CategoryLabel { get; set; }
        public double ServingsPerContainer { get; set; }
        public string Image { get; set; }
    }

    public class Parsed
    {
        public Food Food { get; set; }
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
        public IList<Parsed> Parsed { get; set; }
        public IList<Hint> hints { get; set; }
    }
}
