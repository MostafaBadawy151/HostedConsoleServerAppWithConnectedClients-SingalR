using Microsoft.EntityFrameworkCore;
using MVCClientApp.Models;

namespace MVCClientApp.Context
{
    public class SignalRContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.; Database=SignalRDb; Trusted_connection = true;");
        }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Department> Departments { get; set; }

    }
}
