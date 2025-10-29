using Assignment_24;
using Microsoft.EntityFrameworkCore;

namespace Assignment_24
{
    /// <summary>
    /// Database context for EF Core operations.
    /// </summary>
    public class StudentDbContext : DbContext
    {
        public DbSet<Student> Students { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // SQLite database file in project folder
            optionsBuilder.UseSqlite("Data Source=students.db");
        }
    }
}
