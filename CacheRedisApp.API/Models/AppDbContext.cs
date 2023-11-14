using Microsoft.EntityFrameworkCore;

namespace CacheRedisApp.API.Models
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {
            
        }

        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasData(
                new Product() { Id=1, Name="Laptop", Price=1299},
                new Product() { Id=2, Name="Phone", Price=1199},
                new Product() { Id = 3, Name = "Keyboard", Price = 599 }

                );
            base.OnModelCreating(modelBuilder);
        }
    }
}
