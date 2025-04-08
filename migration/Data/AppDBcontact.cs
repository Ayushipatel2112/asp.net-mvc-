using Microsoft.EntityFrameworkCore;
using migration.Models;

namespace migration.Data
{
    public class AppDBcontact(DbContextOptions<AppDBcontact> options) : DbContext(options)
    {
        public DbSet<Product> Product { get; set; }
    }
}

