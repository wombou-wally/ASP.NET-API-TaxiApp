using Microsoft.EntityFrameworkCore;
namespace TaxiApp.Models
{
    public class TaxiDBContext : DbContext
    {
        public DbSet<Ride> Rides { get; set; }

        public TaxiDBContext(DbContextOptions<TaxiDBContext> options) : base(options) 
        {

        }
    }
}
