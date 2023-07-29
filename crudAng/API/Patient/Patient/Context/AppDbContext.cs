using Microsoft.EntityFrameworkCore;
using Patient.Model;

namespace Patient.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        public DbSet<Patients> Patients { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Patients>().ToTable("Patients");
        }
    }
}
