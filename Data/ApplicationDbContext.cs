using Microsoft.EntityFrameworkCore;
using PosApp.Models;

namespace PosApp.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Product> Products { get; set; } = null!;
        public DbSet<Stock> Stocks { get; set; } = null!;

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasKey(p => p.Sku);
            modelBuilder.Entity<Stock>()
                .HasKey(s => s.Sku);
            modelBuilder.Entity<Stock>()
                .HasOne(s => s.Product)
                .WithOne()
                .HasForeignKey<Stock>(s => s.Sku);
        }
    }
}
