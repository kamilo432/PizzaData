using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PizzaData.Models
{
    public class Flour
    {
        public int Id { get; set; }

        [Required]
        [DisplayName("Flour name")]
        public string? FlourName { get; set; }

        [DisplayName("Flour type")]
        public string ? FlourType { get; set; }

        public decimal? Protein { get; set; }

        public string? Strength { get; set; }
        public string? Elasticity { get; set; }

        [DisplayName("Flour description")]
        public string? FlourDescription { get; set;}
    }
}
