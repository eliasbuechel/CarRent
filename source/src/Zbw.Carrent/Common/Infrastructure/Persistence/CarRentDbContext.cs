using Microsoft.EntityFrameworkCore;
using Zbw.Carrent.CarManagerment.Domain;
using Zbw.Carrent.CustomerManagement.Domain;
using Zbw.Carrent.RentalContractManagement.Domain;
using Zbw.Carrent.ReservationManagement.Domain;

namespace Zbw.Carrent.Common.Infrastructure.Persistence
{
    public class CarRentDbContext : DbContext
    {
        public CarRentDbContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured) 
            {
                optionsBuilder.UseSqlServer("Server=.;Database=CarRent;Trusted_Connection=True;MultipleActiveResultSets=True;Encrypt=False;");
            }

            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Car> Cars { get; set; }
        public DbSet<RentalContract> RentalContracts { get; set; }
        public DbSet<Reservation> Reservations { get; set; }

    }
}