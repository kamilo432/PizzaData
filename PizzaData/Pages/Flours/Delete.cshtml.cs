using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using PizzaData.Data;
using PizzaData.Models;

namespace PizzaData.Pages.Flours
{
    public class DeleteModel : PageModel
    {
        private readonly PizzaData.Data.PizzaDataContext _context;

        public DeleteModel(PizzaData.Data.PizzaDataContext context)
        {
            _context = context;
        }

        [BindProperty]
      public Flour Flours { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Flours == null)
            {
                return NotFound();
            }

            var flours = await _context.Flours.FirstOrDefaultAsync(m => m.Id == id);

            if (flours == null)
            {
                return NotFound();
            }
            else 
            {
                Flours = flours;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null || _context.Flours == null)
            {
                return NotFound();
            }
            var flours = await _context.Flours.FindAsync(id);

            if (flours != null)
            {
                Flours = flours;
                _context.Flours.Remove(Flours);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
