using System.ComponentModel.DataAnnotations;

namespace PizzaData.Models
{
    public class Pizza
    {
        public int Id { get; set; }

        [Required]
        public string? FlourName { get; set; }

        [DisplayFormat(DataFormatString = "{0:N0}")]
        public decimal FlourAmount { get; set; }

        [DisplayFormat(DataFormatString = "{0:N0}")]
        public decimal WaterAmount { get; set; }
        public decimal YeastAmount { get; set; }

        [DisplayFormat(DataFormatString = "{0:N0}")]
        public decimal OliveOilAmount { get; set; }

        [DisplayFormat(DataFormatString = "{0:N0}")]
        public decimal SaltAmount { get; set; }

        [DisplayFormat(DataFormatString = "{0:N0}")]
        public decimal AmbientFermentationTime { get; set; }

        [DisplayFormat(DataFormatString = "{0:N0}")]
        public decimal FridgeFermentationTime { get; set; }
    }
}
