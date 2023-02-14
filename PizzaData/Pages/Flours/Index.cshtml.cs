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
    public class IndexModel : PageModel
    {
        private readonly PizzaData.Data.PizzaDataContext _context;

        public IndexModel(PizzaData.Data.PizzaDataContext context)
        {
            _context = context;
        }

        public IList<Flour> Flours { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Flours != null)
            {
                Flours = await _context.Flours.ToListAsync();
            }
        }
    }
}
