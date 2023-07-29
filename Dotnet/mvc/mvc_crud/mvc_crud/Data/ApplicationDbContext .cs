using Microsoft.EntityFrameworkCore;
using mvc_crud.Models;

namespace mvc_crud.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext>option):base(option)
        { }

        public DbSet<emp> emps { get; set; }
        public object Employees { get; internal set; }
    }
}
