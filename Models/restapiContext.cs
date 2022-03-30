using Microsoft.EntityFrameworkCore;
namespace restapi.Models
{
    public class restapiContext : DbContext
    {
        public restapiContext(DbContextOptions<restapiContext> options)
            : base(options)
        {
        }
        public DbSet<batteries> batteries { get; set; }
        public DbSet<columns> columns { get; set; }
        public DbSet<elevators> elevators { get; set; }
    }
}