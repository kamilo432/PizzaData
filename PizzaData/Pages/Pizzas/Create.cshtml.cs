using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using PizzaData.Data;
using PizzaData.Models;

namespace PizzaData.Pages.Pizzas
{
    public class CreateModel : PageModel
    {
        private readonly PizzaData.Data.PizzaDataContext _context;

        public CreateModel(PizzaData.Data.PizzaDataContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Pizza Pizza { get; set; } = default!;

        public IActionResult OnGet()
        {
            ViewData["Flours"] = _context.Flours.ToList();
            return Page();
        }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid || _context.Pizza == null || Pizza == null)
            {
                return Page();
            }

            _context.Pizza.Add(Pizza);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
