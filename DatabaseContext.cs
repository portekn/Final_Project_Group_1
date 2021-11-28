using Final_Project_Group_1.Models;
using Microsoft.EntityFrameworkCore;
using System;

namespace Final_Project_Group_1
{
    public class DatabaseContext : DbContext
    {
        private DateTime date = new DateTime(2001, 11, 29);
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        { }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Interest>().HasData(
                new Interest
                {
                    Id = 1,
                    InterestName = "Music",
                    InterestYears = 3,
                    Expensive = true,
                    TimeConsumption = 2
                }
                );
            builder.Entity<Location>().HasData(
                new Location
                {
                    Id = 1,
                    State = "New York",
                    City = "New York",
                    ZipCode = 10001,
                    StreetName = "8th Street"
                });
            builder.Entity<Member>().HasData(
                new Member
                {
                    Id = 1,
                    FullName = "Jose Chacon",
                    BirthDate = date,
                    Program = "IT Software Development",
                    Year = "Freshman"
                });
            builder.Entity<Movie>().HasData(
                new Movie
                {
                    Id = 1,
                    MovieName = "Spiderman No Way Home",
                    Director = "Jon Watts",
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
