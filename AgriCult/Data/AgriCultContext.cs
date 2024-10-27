using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using AgriCult.Models;

namespace AgriCult.Data
{
    public class AgriCultContext : DbContext
    {
        public AgriCultContext (DbContextOptions<AgriCultContext> options)
            : base(options)
        {
        }

        public DbSet<AgriCult.Models.Employee> Employee { get; set; } = default!;
        public DbSet<AgriCult.Models.Farmer> Farmer { get; set; } = default!;
        public DbSet<AgriCult.Models.WorkShop> WorkShop { get; set; } = default!;
    }
}
