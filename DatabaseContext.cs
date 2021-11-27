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
                    InterestName = "Studies",
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
                    BirthDate = "11/29/2001",
                    Program = "IT",
                    Year = "Freshman"
                });
            builder.Entity<Movie>().HasData(
                new Movie
                {
                    Id = 1,
                    MovieName = "Spiderman No Way Home",
                    Director = "Georgi",
                    Score = 9,
                    Type = "Action",
                    Year = 2021
                });
        }

        public DbSet<Member> Members { get; set; }
        public DbSet<Interest> Interests { get; set; }
        public DbSet<Location> Locations { get; set; }
        public DbSet<Movie> Movies { get; set; }

    }
}
