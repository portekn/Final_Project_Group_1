using Microsoft.EntityFrameworkCore;
using Final_Project_Group_1.Models;

namespace Final_Project_Group_1
{
    public class LocationContext : DbContext
    {
        public LocationContext(DbContextOptions<LocationContext> options) : base(options)
        { }

        public DbSet<Location> Locations { get; set; }
    }
}