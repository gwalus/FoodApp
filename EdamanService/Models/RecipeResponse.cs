using System;
using System.Collections.Generic;
using System.Text;

namespace EdamanService.Models
{
    public class Ingredient
    {
        public string text { get; set; }
        public double weight { get; set; }
        public string image { get; set; }
    }

    public class ENERCKCAL
    {
        public string label { get; set; }
        public double quantity { get; set; }
        public string unit { get; set; }
    }

    public class FAT
    {
        public string label { get; set; }
        public double quantity { get; set; }
        public string unit { get; set; }
    }

    public class FASAT
    {
        public string label { get; set; }
        public double quantity { get; set; }
        public string unit { get; set; }
    }

    public class FATRN
    {
        public string label { get; set; }
        public double quantity { get; set; }
        public string unit { get; set; }
    }

    public class FAMS
    {
        public string label { get; set; }
        public double quantity { get; set; }
        public string unit { get; set; }
    }

    public class FAPU
    {
        public string label { get; set; }
        public double quantity { get; set; }
        public string unit { get; set; }
    }

    public class CHOCDF
    {
        public string label { get; set; }
        public double quantity { get; set; }
        public string unit { get; set; }
    }

    public class FIBTG
    {
        public string label { get; set; }
        public double quantity { get; set; }
        public string unit { get; set; }
    }

    public class SUGAR
    {
        public string label { get; set; }
        public double quantity { get; set; }
        public string unit { get; set; }
    }

    public class PROCNT
    {
        public string label { get; set; }
        public double quantity { get; set; }
        public string unit { get; set; }
    }

    public class CHOLE
    {
        public string label { get; set; }
        public double quantity { get; set; }
        public string unit { get; set; }
    }

    public class NA
    {
        public string label { get; set; }
        public double quantity { get; set; }
        public string unit { get; set; }
    }

    public class CA
    {
        public string label { get; set; }
        public double quantity { get; set; }
        public string unit { get; set; }
    }

    public class MG
    {
        public string label { get; set; }
        public double quantity { get; set; }
        public string unit { get; set; }
    }

    public class K
    {
        public string label { get; set; }
        public double quantity { get; set; }
        public string unit { get; set; }
    }

    public class FE
    {
        public string label { get; set; }
        public double quantity { get; set; }
        public string unit { get; set; }
    }

    public class ZN
    {
        public string label { get; set; }
        public double quantity { get; set; }
        public string unit { get; set; }
    }

    public class P
    {
        public string label { get; set; }
        public double quantity { get; set; }
        public string unit { get; set; }
    }

    public class VITARAE
    {
        public string label { get; set; }
        public double quantity { get; set; }
        public string unit { get; set; }
    }

    public class VITC
    {
        public string label { get; set; }
        public double quantity { get; set; }
        public string unit { get; set; }
    }

    public class THIA
    {
        public string label { get; set; }
        public double quantity { get; set; }
        public string unit { get; set; }
    }

    public class RIBF
    {
        public string label { get; set; }
        public double quantity { get; set; }
        public string unit { get; set; }
    }

    public class NIA
    {
        public string label { get; set; }
        public double quantity { get; set; }
        public string unit { get; set; }
    }

    public class VITB6A
    {
        public string label { get; set; }
        public double quantity { get; set; }
        public string unit { get; set; }
    }

    public class FOLDFE
    {
        public string label { get; set; }
        public double quantity { get; set; }
        public string unit { get; set; }
    }

    public class FOLFD
    {
        public string label { get; set; }
        public double quantity { get; set; }
        public string unit { get; set; }
    }

    public class FOLAC
    {
        public string label { get; set; }
        public double quantity { get; set; }
        public string unit { get; set; }
    }

    public class VITB12
    {
        public string label { get; set; }
        public double quantity { get; set; }
        public string unit { get; set; }
    }

    public class VITD
    {
        public string label { get; set; }
        public double quantity { get; set; }
        public string unit { get; set; }
    }

    public class TOCPHA
    {
        public string label { get; set; }
        public double quantity { get; set; }
        public string unit { get; set; }
    }

    public class VITK1
    {
        public string label { get; set; }
        public double quantity { get; set; }
        public string unit { get; set; }
    }

    public class WATER
    {
        public string label { get; set; }
        public double quantity { get; set; }
        public string unit { get; set; }
    }

    public class TotalNutrients
    {
        public ENERCKCAL ENERC_KCAL { get; set; }
        public FAT FAT { get; set; }
        public FASAT FASAT { get; set; }
        public FATRN FATRN { get; set; }
        public FAMS FAMS { get; set; }
        public FAPU FAPU { get; set; }
        public CHOCDF CHOCDF { get; set; }
        public FIBTG FIBTG { get; set; }
        public SUGAR SUGAR { get; set; }
        public PROCNT PROCNT { get; set; }
        public CHOLE CHOLE { get; set; }
        public NA NA { get; set; }
        public CA CA { get; set; }
        public MG MG { get; set; }
        public K K { get; set; }
        public FE FE { get; set; }
        public ZN ZN { get; set; }
        public P P { get; set; }
        public VITARAE VITA_RAE { get; set; }
        public VITC VITC { get; set; }
        public THIA THIA { get; set; }
        public RIBF RIBF { get; set; }
        public NIA NIA { get; set; }
        public VITB6A VITB6A { get; set; }
        public FOLDFE FOLDFE { get; set; }
        public FOLFD FOLFD { get; set; }
        public FOLAC FOLAC { get; set; }
        public VITB12 VITB12 { get; set; }
        public VITD VITD { get; set; }
        public TOCPHA TOCPHA { get; set; }
        public VITK1 VITK1 { get; set; }
        public WATER WATER { get; set; }
    }

    //    public class TotalDaily
    //    {
    //        public ENERCKCAL ENERC_KCAL { get; set; }
    //    public FAT { get; set; }
    //public FASAT
    //{ get; set; }
    //public CHOCDF
    //{ get; set; }
    //public FIBTG
    //{ get; set; }
    //public PROCNT
    //{ get; set; }
    //public CHOLE
    //{ get; set; }
    //public NA
    //{ get; set; }
    //public CA
    //{ get; set; }
    //public MG
    //{ get; set; }
    //public K
    //{ get; set; }
    //public FE
    //{ get; set; }
    //public ZN
    //{ get; set; }
    //public P
    //{ get; set; }
    //public VITA_RAE
    //{ get; set; }
    //public VITC
    //{ get; set; }
    //public THIA
    //{ get; set; }
    //public RIBF
    //{ get; set; }
    //public NIA
    //{ get; set; }
    //public VITB6A
    //{ get; set; }
    //public FOLDFE
    //{ get; set; }
    //public VITB12
    //{ get; set; }
    //public VITD
    //{ get; set; }
    //public TOCPHA
    //{ get; set; }
    //public VITK1
    //{ get; set; }
    //    }

    public class Sub
    {
        public string label { get; set; }
        public string tag { get; set; }
        public string schemaOrgTag { get; set; }
        public double total { get; set; }
        public bool hasRDI { get; set; }
        public double daily { get; set; }
        public string unit { get; set; }
    }

    public class Digest
    {
        public string label { get; set; }
        public string tag { get; set; }
        public string schemaOrgTag { get; set; }
        public double total { get; set; }
        public bool hasRDI { get; set; }
        public double daily { get; set; }
        public string unit { get; set; }
        public IList<Sub> sub { get; set; }
    }

    public class Recipe
    {
        public string uri { get; set; }
        public string label { get; set; }
        public string image { get; set; }
        public string source { get; set; }
        public string url { get; set; }
        public string shareAs { get; set; }
        public double yield { get; set; }
        public IList<string> dietLabels { get; set; }
        public IList<string> healthLabels { get; set; }
        public IList<string> cautions { get; set; }
        public IList<string> ingredientLines { get; set; }
        public IList<Ingredient> ingredients { get; set; }
        public double calories { get; set; }
        public double totalWeight { get; set; }
        public double totalTime { get; set; }
        public TotalNutrients totalNutrients { get; set; }
        //public TotalDaily totalDaily { get; set; }
        public IList<Digest> digest { get; set; }
    }

    public class Hit
    {
        public Recipe recipe { get; set; }
        public bool bookmarked { get; set; }
        public bool bought { get; set; }
    }

    public class RecipeResponse
    {
        public string q { get; set; }
        public int from { get; set; }
        public int to { get; set; }
        public bool more { get; set; }
        public int count { get; set; }
        public IList<Hit> Hits { get; set; }
    }
}
