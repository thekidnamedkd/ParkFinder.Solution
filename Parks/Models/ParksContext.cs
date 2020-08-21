using Microsoft.EntityFrameworkCore;

namespace Parks.Models
{
    public class ParksContext : DbContext
    {
        public ParksContext(DbContextOptions<ParksContext> options)
            : base(options)
        {
        }

        public DbSet<National> Nationals { get; set; }
        public DbSet<State> States { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
        builder.Entity<National>()
            .HasData(
                new National { NationalId = 1, NationalParkName = "Glacier National Park", NationalName = "USA", NationalParkYear = 1910 },
                new National { NationalId = 2, NationalParkName = "Grand Canyon National Park", NationalName = "USA", NationalParkYear = 1919 },
                new National { NationalId = 3, NationalParkName = "Crater Lake National Park", NationalName = "USA", NationalParkYear = 1902 },
                new National { NationalId = 4, NationalParkName = "Yellowstone National Park", NationalName = "USA", NationalParkYear = 1872 },
                new National { NationalId = 5, NationalParkName = "Yosemite National Park", NationalName = "USA", NationalParkYear = 1890 }
                
            );
        }
    }
}