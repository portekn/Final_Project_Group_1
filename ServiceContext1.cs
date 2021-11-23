using Microsoft.EntityFrameworkCore;
using Final_Project_Group_1.Models;

namespace Final_Project_Group_1
{
    public class LocationContext1 : DbContext
    {
        public LocationContext1(DbContextOptions<LocationContext> options) : base(options)
        { }

        public DbSet<Location> Locations { get; set; }
    }
}