using AspNetCoreWebApi.Models;
using Microsoft.EntityFrameworkCore;

namespace AspNetCoreWebApi.Data
{
    public class HumanContext: DbContext
    {
        public DbSet<Human> Humans { get; set; }
        public HumanContext(DbContextOptions<HumanContext> options): base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Human>().Property(h => h.Id).ValueGeneratedOnAdd();
        }
    }
}