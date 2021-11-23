using Microsoft.EntityFrameworkCore;
using Final_Project_Group_1.Models;

namespace Final_Project_Group_1
{
    public class MovieContext : DbContext
    {
        public MovieContext(DbContextOptions<MovieContext> options) : base(options)
        { }

        public DbSet<Movie> Movies { get; set; }
    }
}
