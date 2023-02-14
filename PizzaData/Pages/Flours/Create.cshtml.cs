using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using PizzaData.Data;
using PizzaData.Models;

namespace PizzaData.Pages.Flours
{
    public class CreateModel : PageModel
    {
        private readonly PizzaData.Data.PizzaDataContext _context;

        public CreateModel(PizzaData.Data.PizzaDataContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Flour Flours { get; set; } = default!;
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid || _context.Flours == null || Flours == null)
            {
                return Page();
            }

            _context.Flours.Add(Flours);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
