using Clean_Architecture.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace Clean_Architecture.Infrastructure.AppDbContext
{
    public class AppDbContext : DbContext
    {
        public AppDbContext()
        {

        }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Student> Students { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Server=localhost;Port=5432;Database=Linda1;user id=postgres;password=quvonch11");
        }
    }
}
