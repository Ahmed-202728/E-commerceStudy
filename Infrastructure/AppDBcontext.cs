
using Domain.Entites;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure
{
    public class AppDBcontext : DbContext
    {
        public AppDBcontext(DbContextOptions<AppDBcontext> options) : base(options)
        {
        }
        // Define your DbSets here, for example:
        public DbSet<Company>Companies { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductImage> ProductImages { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems  { get; set; }

        //onCreateModel method to configure the model
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Company>().Property(c => c.Id).HasDefaultValueSql("NEWID()");
            modelBuilder.Entity<Category>().Property(c => c.Id).HasDefaultValueSql("NEWID()");
            modelBuilder.Entity<Product>().Property(c => c.Id).HasDefaultValueSql("NEWID()");
            modelBuilder.Entity<ProductImage>().Property(c => c.Id).HasDefaultValueSql("NEWID()");
            modelBuilder.Entity<Customer>().Property(c => c.Id).HasDefaultValueSql("NEWID()");
            modelBuilder.Entity<Order>().Property(c => c.Id).HasDefaultValueSql("NEWID()");
            modelBuilder.Entity<OrderItem>().Property(c => c.Id).HasDefaultValueSql("NEWID()");
            base.OnModelCreating(modelBuilder);
            // Configure your entities here
        }
    }
}
