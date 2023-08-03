using Microsoft.EntityFrameworkCore;

namespace RazorPagesApp
{
    public class HoomanDbContext: DbContext
    {
        public DbSet<Hooman> ListOfHoomans { get; set; }
        public HoomanDbContext(DbContextOptions<HoomanDbContext> options): base(options)
        {

        }
    }
}
