using Microsoft.EntityFrameworkCore;
using cozynibi.Models;


namespace cozynibi.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options) { }

        public DbSet<Room> Rooms { get; set; }
    }
}
