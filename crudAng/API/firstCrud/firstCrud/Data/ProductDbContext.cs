using firstCrud.Models;
using Microsoft.EntityFrameworkCore;

namespace firstCrud.Data
{
    public class ProductDbContext : DbContext
    {
        public ProductDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<product> Products { get; set; }
    }
}
