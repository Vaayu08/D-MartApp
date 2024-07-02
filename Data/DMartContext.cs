using D_MartApp.Models;
using Microsoft.EntityFrameworkCore;

namespace D_MartApp.Data
{
    public class DMartContext: DbContext
    {
        public DMartContext(DbContextOptions<DMartContext> options)
        : base(options)
        { 
        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Sale> Sales { get; set; }
        public DbSet<Shift> Shifts { get; set; }

    }
}
