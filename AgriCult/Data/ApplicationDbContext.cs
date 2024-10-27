using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace AgriCult.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {

        }
        public DbSet<AgriCult.Models.Employee> Employee { get; set; } = default!;
        public DbSet<AgriCult.Models.Farmer> Farmer { get; set; } = default!;
        public DbSet<AgriCult.Models.WorkShop> WorkShop { get; set; } = default!;
    }
}
