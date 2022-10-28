using Microsoft.EntityFrameworkCore;
using MyGuide.DAL.Entities;

namespace MyGuide.DAL.DbContexts
{
    public class AppDbContext : DbContext
    {
        public DbSet<City> Cities { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        { }
    }
}
