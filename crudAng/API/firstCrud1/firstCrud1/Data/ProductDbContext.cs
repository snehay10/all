using firstCrud1.Models;
using Microsoft.EntityFrameworkCore;

namespace firstCrud1.Data
{
    public class ProductDbContext : DbContext
    {
        public ProductDbContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Product> Product { get; set; }
    }
}
