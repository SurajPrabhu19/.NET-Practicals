using Microsoft.EntityFrameworkCore;

namespace EntityCoreFrameworkImplementation.Models
{
    public class StudentDbContext: DbContext
    {
        public StudentDbContext(DbContextOptions<StudentDbContext> options): base(options)
        {
            
        }

        public DbSet<StudentModel> Student { get; set; }    // Represents table of the database
    }
}
