namespace BethanysPieShopProject.Models
{
    using System.ComponentModel.DataAnnotations;

    public class Pie
    {
        public int PieId { get; set; }
        [Display(Name = "Name")]
        public string Name { get; set; }
        [Display(Name = "ShortDescription")]
        public string ShortDescription { get; set; }
        [Display(Name = "LongDescription")]
        public string LongDescription { get; set; }
        [Display(Name = "AllergyInformation")]
        public string AllergyInformation { get; set; }
        public string ImageUrl { get; set; }
        public string ImageThumbnailUrl { get; set; }
        [Display(Name = "Price")]
        public decimal Price { get; set; }
        public int CategoryId { get; set; }
        [Display(Name = "Category")]
        public Category Category { get; set; }
        [Display(Name = "IsPieOfTheWeek")]
        public bool IsPieOfTheWeek { get; set; }
        [Display(Name = "InStock")]
        public bool InStock { get; set; }


    }
}
