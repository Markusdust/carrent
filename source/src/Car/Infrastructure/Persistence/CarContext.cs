using Microsoft.EntityFrameworkCore;


namespace CarRent.Car.Infrastructure.Persistence
{
    using CarRent.Car.Domain;
    using CarRent.Customer.Domain;

    public class CarContext : DbContext
    {
        public DbSet<Car> Cars { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<CarClass> CarClasses { get; set; }
        public DbSet<Type> Types { get; set; }

        public DbSet<Customer> Customers { get; set; }


        public CarContext(DbContextOptions options) : base(options) { }

        //string connectionString = "Server=(localdb)\\mssqllocaldb;Database=CarRent;Trusted_Connection=True;MultipleActiveResultSets=true";

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer(connectionString);
        //}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Car>(
                x =>
                {
                    x.HasKey(y => y.Id);
                    x.HasIndex(y => y.CarNumber);
                    x.HasOne(y => y.CarClass);
                    x.HasOne(y => y.Brand);
                    x.HasOne(y => y.Type);
                }
            );

            modelBuilder.Entity<CarClass>(
                x =>
                {
                    x.HasKey(y => y.Id);
                }
            );

            modelBuilder.Entity<Brand>(
                x =>
                {
                    x.HasKey(y => y.Id);
                }
            );

            modelBuilder.Entity<Type>(
                x =>
                {
                    x.HasKey(y => y.Id);
                }
            );

            modelBuilder.Entity<Customer>(
                x =>
                {
                    x.HasKey(y => y.Id);
                }
            );

            base.OnModelCreating(modelBuilder);
        }
    }
}
