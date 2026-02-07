using Microsoft.EntityFrameworkCore;
using cozynibi.Models;


namespace cozynibi.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options) { }

        public DbSet<Room> Rooms { get; set; }
        public DbSet<Menu> Menus { get; set; }
        public DbSet<About> Abouts { get; set; }

    }
}
