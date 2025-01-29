using Microsoft.EntityFrameworkCore;

namespace WebApiEmployee__.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        { }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Departements { get; set; }

    }
}
