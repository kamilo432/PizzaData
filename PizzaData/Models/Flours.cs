using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace PizzaData.Models
{
    public class Flours
    {
        [Required]
        [DisplayName("Flour name")]
        public string? FlourName { get; set; }
    }
}
