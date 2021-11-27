using Final_Project_Group_1.Models;
using Microsoft.EntityFrameworkCore;

namespace Final_Project_Group_1
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        { }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Interest>().HasData(
                new Interest
                {
                    Id = 1,
                    interest = "Studies",
                    InterestYears = 3,
                    Expensive = true,
                    TimeConsumption = 2
                }
                );
            builder.Entity<Location>().HasData(
                new Location
                {
                    Id = 1,
                    State = "Test",
                    City = "Cusco",
                    ZipCode = 08000,
                    StreetName = "Los Saucos"
                });
            builder.Entity<Member>().HasData(
                new Member
                {
                    Id = 1,
                    FullName = "Jose Chacon",
                    BirthDate = 2001,
                    Program = "IT",
                    YOD = 2025
                });
        }

        public DbSet<Member> Members { get; set; }
        public DbSet<Interest> Interests { get; set; }
        public DbSet<Location> Locations { get; set; }

    }
}
