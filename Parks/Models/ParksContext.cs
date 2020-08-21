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
        builder.Entity<State>()
            .HasData(
                new State { StateId = 1, StateParkName = "Niagara Falls State Park", StateName = "New York", StateParkYear = 1885 },
                new State { StateId = 2, StateParkName = "Porcupine Mountains Wilderness State Park", StateName = "Michigan", StateParkYear = 1944 },
                new State { StateId = 3, StateParkName = "Ecola State Park", StateName = "Oregon", StateParkYear = 1932 },
                new State { StateId = 4, StateParkName = "Tettegouche State Park", StateName = "Minnesota", StateParkYear = 1979 },
                new State { StateId = 5, StateParkName = "Valley of Fire State Park", StateName = "Nevada", StateParkYear = 1935 }
                
            );
        }
    }
}