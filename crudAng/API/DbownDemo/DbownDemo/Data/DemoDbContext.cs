using DbownDemo.Models;
using Microsoft.EntityFrameworkCore;

namespace DbownDemo.Data
{
    public class DemoDbContext : DbContext
    {
        public DemoDbContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<User> users { get; set; }
    }
   
}
