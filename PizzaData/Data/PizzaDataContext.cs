using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PizzaData.Models;

namespace PizzaData.Data
{
    public class PizzaDataContext : DbContext
    {
        public PizzaDataContext (DbContextOptions<PizzaDataContext> options)
            : base(options)
        {
        }

        public DbSet<PizzaData.Models.Pizza> Pizza { get; set; } = default!;
    }
}
