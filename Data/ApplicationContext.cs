using CourierBid.Models;
using Microsoft.EntityFrameworkCore;

namespace CourierBid.Data
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options)
            : base(options)
        {
        }
        public DbSet<TruckModels> TruckModels { get; set; }
        public DbSet<Trucks> Trucks { get; set; }
        public DbSet<Transports> Transports { get; set; }
        public DbSet<Expeditions> Expeditions { get; set; }
        public DbSet<Contracts> Contracts { get; set; }
        public DbSet<CargoTypes> CargoTypes { get; set; }
        public DbSet<Cargo> Cargo { get; set; }
        // aici faci set-uri cu modele (truckmodels, tu o sa faci model pentru fiecare in parte din tabelul lui nick)
    }
}