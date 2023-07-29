using Microsoft.EntityFrameworkCore;
using RazorDemo.Models.Domain;

namespace RazorDemo.Data
{
    public class RezorPagesDbContextDemo : DbContext
    {
        public RezorPagesDbContextDemo(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Employee> Employee { get; set; }
    }
}
