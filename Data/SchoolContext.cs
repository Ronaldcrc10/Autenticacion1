using Authent.Models;
using Microsoft.EntityFrameworkCore;

namespace Authent.Data
{
    public class SchoolContext : DbContext
    {
            public SchoolContext(DbContextOptions options) : base(options)
            {
            }

            public DbSet<Student> Students { get; set; }
            public DbSet<Teacher> Teachers { get; set; }

            protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            {
                optionsBuilder.UseSqlServer(
                    "Server=(localdb)\\mssqllocaldb;Database=SupermarketEF;Trusted_Connection=True");
            }
    }
}
