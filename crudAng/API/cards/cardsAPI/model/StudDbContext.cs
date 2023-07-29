using Microsoft.EntityFrameworkCore;

namespace cardsAPI.model
{
    public class StudDbContext : DbContext
    {
        public StudDbContext(DbContextOptions<StudDbContext> options) : base(options)
        {
        }

        public DbSet<stud> stud { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-QNJIJNF\\SQLEXPRESS;Initial Catalog=dbNet;Integrated Security=True;Encrypt=False");
        }
    }
}
