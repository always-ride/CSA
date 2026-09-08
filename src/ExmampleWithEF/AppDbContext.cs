using Microsoft.EntityFrameworkCore;

namespace ExmampleWithEF
{
    public class AppDbContext : DbContext
    {
        public DbSet<Product> Products => Set<Product>();

        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite("Data Source=shop.db");
    }
}
