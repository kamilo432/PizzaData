using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PizzaData.Data;
using PizzaData.Models;

namespace PizzaData.Pages.Flours
{
    public class EditModel : PageModel
    {
        private readonly PizzaData.Data.PizzaDataContext _context;

        public EditModel(PizzaData.Data.PizzaDataContext context)
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

            var flours =  await _context.Flours.FirstOrDefaultAsync(m => m.Id == id);
            if (flours == null)
            {
                return NotFound();
            }
            Flours = flours;
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Flours).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!FloursExists(Flours.Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool FloursExists(int id)
        {
          return (_context.Flours?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
