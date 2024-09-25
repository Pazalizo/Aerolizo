using Microsoft.EntityFrameworkCore;

namespace Aerolizo.Data

{
    public class AerolizoContext : DbContext
    {
        public AerolizoContext(DbContextOptions<AerolizoContext> options)
            : base(options)
        {
        }

        public DbSet<Aerolizo.Models.Movie> Movie { get; set; } = default!;
    }
}