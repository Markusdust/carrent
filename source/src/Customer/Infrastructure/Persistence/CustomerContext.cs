using System.Runtime.CompilerServices;
using Microsoft.EntityFrameworkCore;

namespace CarRent.Customer.Infrastructure.Persistence
{
    using CarRent.Customer.Domain;
    public class CustomerContext : DbContext
    {
        public DbSet<Customer> Customers { get; set; }

        public CustomerContext(DbContextOptions options) : base(options)
        {
            Database.EnsureCreated();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("Customer");
            modelBuilder.Entity<Customer>(
                x =>
                {
                    x.HasKey(y => y.Id);
                    x.Property(y => y.PassportNumber);
                    x.Property(y => y.Firstname);
                    x.Property(y => y.Lastname);
                    x.Property(y => y.Street);
                    x.Property(y => y.City);
                    x.Property(y => y.Country);
                }
            );

            base.OnModelCreating(modelBuilder);
        }
    }
}
