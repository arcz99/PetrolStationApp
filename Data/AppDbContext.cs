using Microsoft.EntityFrameworkCore;

namespace StacjaBenzynowaApp.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Paliwo> Paliwa { get; set; }

        // Konstruktor
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }
    }
}