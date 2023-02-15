using PizzaData.Pages.Flours;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using PizzaData.Models;

namespace PizzaData.Models
{
    public class Pizza
    {
        public int Id { get; set; }

        public List<Flour>? Flours { get; set; }


        [Required]
        [DisplayName("Flour name")]
        public string? Name { get; set; }

        [DisplayName("Flour amount")]
        [DisplayFormat(DataFormatString = "{0:N0}")]
        public decimal FlourAmount { get; set; }

        [DisplayName("Water amount")]
        [DisplayFormat(DataFormatString = "{0:N0}")]
        public decimal WaterAmount { get; set; }

        [DisplayFormat(DataFormatString = "{0:N0}")]
        public decimal Hydration
        {
            get
            {
                if (FlourAmount == 0)
                {
                    return 0;
                }
                return WaterAmount / FlourAmount * 100;
            }
        }

        [DisplayName("Yeast amount")]
        public decimal YeastAmount { get; set; }

        [DisplayName("Olive oil amount")]
        [DisplayFormat(DataFormatString = "{0:N0}")]
        public decimal OliveOilAmount { get; set; }

        [DisplayName("Salt amount")]
        [DisplayFormat(DataFormatString = "{0:N0}")]
        public decimal SaltAmount { get; set; }

        [DisplayName("Ambient fermentation time")]
        [DisplayFormat(DataFormatString = "{0:N0}")]
        public decimal AmbientFermentationTime { get; set; }

        [DisplayName("Fridge fermentation time")]
        [DisplayFormat(DataFormatString = "{0:N0}")]
        public decimal FridgeFermentationTime { get; set; }
    }
}
