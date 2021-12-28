using CourierBid.Models;
using Microsoft.EntityFrameworkCore;

namespace CourierBid.Data
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions options)
            : base(options)
        {
        }
        public DbSet<TruckModels> TruckModels { get; set; }
        // aici faci set-uri cu modele (truckmodels, tu o sa faci model pentru fiecare in parte din tabelul lui nick)
    }
}
