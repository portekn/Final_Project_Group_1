using Microsoft.EntityFrameworkCore;
using Final_Project_Group_1.Models;

namespace Final_Project_Group_1
{
    public class BasicContext : DbContext
    {
        public BasicContext(DbContextOptions<BasicContext> options) : base(options)
        { }

        public DbSet<Basic> Basics { get; set; }
    }
}