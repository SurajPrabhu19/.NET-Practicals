using Microsoft.EntityFrameworkCore;

namespace EntityCoreFrameworkImplementation.Models
{
    public class EmployeeModelDbContext : DbContext
    {
        public EmployeeModelDbContext(DbContextOptions<EmployeeModelDbContext> options) : base(options)
        {
            
        }

        public DbSet<EmployeeModel> Employee { get; set; }
    }
}
