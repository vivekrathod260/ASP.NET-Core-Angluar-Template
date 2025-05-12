using Microsoft.EntityFrameworkCore;
using Data.Entities;

namespace Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        { }

        public DbSet<Customer> Customers { get; set; }

        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //
        }
    }
}
