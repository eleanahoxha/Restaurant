using Microsoft.EntityFrameworkCore;

namespace Restaurants.API
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Models.Restaurant> Restaurants { get; set; }
    }
}
