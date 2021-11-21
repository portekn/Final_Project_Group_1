using Microsoft.EntityFrameworkCore;
using Final_Project_Group_1.Model;
using System.Data.Entity;

namespace Final_Project_Group_1
{
    public class ServiceContext2 : DbContext
    {
        public ServiceContext2(DbContextOptions<ServiceContext2> options) : base(options)
        { }

        public DbSet<Variable> Variables { get; set; }
    }
}