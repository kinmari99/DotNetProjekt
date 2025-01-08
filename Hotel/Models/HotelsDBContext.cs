using Microsoft.EntityFrameworkCore;

namespace Hotel.Models
{
    public class HotelsDBContext : DbContext
    {
        public HotelsDBContext(DbContextOptions<HotelsDBContext> options) : base(options)
        { }
        public DbSet<Newsletter> Newsletters { get; set; }

        public DbSet<Rezerwacja> Reservations { get; set; }

        public DbSet<Użytkownik> Users {  get; set; }

        public DbSet<Pracownik> Workers { get; set; }




    }
}
