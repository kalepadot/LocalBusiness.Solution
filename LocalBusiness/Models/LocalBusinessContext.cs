using Microsoft.EntityFrameworkCore;

namespace LocalBusiness.Models
{
    public class LocalBusinessContext : DbContext
    {
        public LocalBusinessContext(DbContextOptions<LocalBusinessContext> options)
            : base(options)
        {
        }

        public DbSet<Restaurant> Restaurants { get; set; }
        protected override void OnModelCreating(ModelBuilder builder)
        {
          builder.Entity<Restaurant>()
            .HasData(
          new Restaurant { RestaurantId = 1, Name = "Harus Bakery", Type= "Bakery" },
          new Restaurant { RestaurantId = 2, Name = "Harus Cafe", Type= "Cafe" },
          new Restaurant { RestaurantId = 3, Name = "House of Haru", Type= "Sushi" },
          new Restaurant { RestaurantId = 4, Name = "Ristorante Harus", Type= "Italian" }
          );
        }
    }
}