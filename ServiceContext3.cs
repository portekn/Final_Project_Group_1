using Microsoft.EntityFrameworkCore;
using Final_Project_Group_1.Models;

namespace Final_Project_Group_1
{
    public class InterestContext : DbContext
    {
        public InterestContext(DbContextOptions<InterestContext> options) : base(options)
        { }

        public DbSet<Interest> Interests { get; set; }
    }
}