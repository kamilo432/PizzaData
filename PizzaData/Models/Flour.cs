using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace PizzaData.Models
{
    public class Flour
    {
        public int Id { get; set; }


        [Required]
        [DisplayName("Flour name")]
        public string? FlourName { get; set; }
        public string ? FlourType { get; set; }
        public decimal? Protein { get; set; }
        public string? Strength { get; set; }
        public string? Elasticity { get; set; }
        public string? FlourDescription { get; set;}
    }
}
