using Microsoft.AspNetCore.Mvc;
using System.ComponentModel;

namespace PizzaData.Models
{
    public class Calculator
    {
        public int Id { get; set; }
        [DisplayName("Weight of ball")]
        public decimal BallWeight { get; set; }
        public decimal Hydration { get; set; }
        [DisplayName("Number of balls")]
        public decimal NumberOfBalls { get; set; }

    }
}
