using Microsoft.EntityFrameworkCore;

namespace BestRestaurants.Models
{
  public class BestRestaurantsContext : DbContext
  {
    public virtual DbSet<Stylist> Stylists { get; set; }
    public DbSet<Client> Clients { get; set; }

    public HairSalonContext(DbContextOptions options) : base(options) { }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
      optionsBuilder.UseLazyLoadingProxies();
    }
  }
}