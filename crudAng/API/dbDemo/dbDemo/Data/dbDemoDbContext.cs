using dbDemo.Models;
using Microsoft.EntityFrameworkCore;

namespace dbDemo.Data
{
    public class dbDemoDbContext : DbContext
    {
        public dbDemoDbContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<student> Students { get; set; }
    }
}
