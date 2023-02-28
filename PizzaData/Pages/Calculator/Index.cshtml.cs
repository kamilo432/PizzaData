using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using NuGet.Versioning;
using PizzaData.Data;
using PizzaData.Models;
using static System.Net.Mime.MediaTypeNames;

namespace PizzaData.Pages.Calculator
{
    public class IndexModel : PageModel
    {
        private readonly PizzaData.Data.PizzaDataContext _context;

        public IndexModel(PizzaData.Data.PizzaDataContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public PizzaData.Models.Calculator Calculator { get; set; } = default!;
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid || _context.Calculator == null || Calculator == null)
            {
                return Page();
            }

            _context.Calculator.Add(Calculator);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }


        public IActionResult OnPostCalculateDough()
        {
            //ModelState.Clear();
            //ModelState.SetModelValue("Calculator.NumberOfPizzas", new ValueProviderResult("10", CultureInfo.InvariantCulture));

            var flour = (Calculator.BallWeight * 0.599m) * Calculator.NumberOfPizzas;
            var water = (flour * Calculator.Hydration) / 100;
            var salt = flour / 32.6m;
            var yeast = flour / 611.37m;

            string cardHtml = $@"
                <div class='card w-50'>
                    <div class='card-body'>
                        <h5>Recipe</h5>
                        <p class='card-text'>Flour: {flour.ToString("0")} g</p>
                        <p class='card-text'>Water: {water.ToString("0")} g</p>
                        <p class='card-text'>Salt: {salt.ToString("0.0")} g</p>
                        <p class='card-text'>Yeast: {yeast.ToString("0.00")} g</p>
                    </div>
                </div>";

            ViewData["cardHtml"] = cardHtml;

            return Page();
        }

    }
}
