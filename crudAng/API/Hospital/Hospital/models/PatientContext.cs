using Microsoft.EntityFrameworkCore;

namespace Hospital.models
{
    public class PatientContext :DbContext

    {
        public PatientContext(DbContextOptions options) : base(options)
        {
            
        }

        public DbSet<patient> patient { get; set; }


    }
}
