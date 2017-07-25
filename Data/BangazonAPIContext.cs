using Microsoft.EntityFrameworkCore;
using BangazonAPI.Models;

namespace BangazonAPI.Data
{
    public class BangazonAPIContext : DbContext
    {
        public BangazonAPIContext(DbContextOptions<BangazonAPIContext> options)
            : base(options)
        { }

        public DbSet<Customer> Customer { get; set; }
        public DbSet<Order> Order { get; set; }
        // public DbSet<Product> Product { get; set; }
        // public DbSet<ProductType> ProductType { get; set; }
        // public DbSet<PaymentType> PaymentType { get; set; }
        // public DbSet<Employee> Employee { get; set; }
        // public DbSet<Department> Department { get; set; }
        // public DbSet<TrainingProgram> TrainingProgram { get; set; }
        // public DbSet<Computer> Computer { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // If a model has a date field that should be generated by the database
            modelBuilder.Entity<Customer>()
                .Property(b => b.DateCreated)
                .HasDefaultValueSql("strftime('%Y-%m-%d')");
            // Sets the DateCreated for the Order. -- Eliza
            modelBuilder.Entity<Order>()
                .Property(c => c.DateCreated)
                .HasDefaultValueSql("strftime('%Y-%m-%d')");
        }

    }
}