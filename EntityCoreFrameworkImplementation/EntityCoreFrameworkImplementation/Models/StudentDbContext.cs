﻿using Microsoft.EntityFrameworkCore;

namespace EntityCoreFrameworkImplementation.Models
{
    public class StudentDbContext: DbContext
    {
        public StudentDbContext(DbContextOptions options): base(options)
        {
            
        }

        public DbSet<StudentDbContext> Student { get; set; }    // Represents table of the database
    }
}
