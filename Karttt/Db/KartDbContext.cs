using Microsoft.EntityFrameworkCore;
using Karttt.Interfaces;
using Karttt.Classes;

namespace Karttt.Db
{
    public class KartDbContext : DbContext
    {
        public DbSet<KartItem> KartItems { get; set; }
        private readonly IKartItemGenerator _generator;
        public KartDbContext(DbContextOptions<KartDbContext> options, IKartItemGenerator generator) : base(options) 
        {
            this._generator = generator;
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            for (int i = 0; i < 15; i++)
            {
                IKartItem kartItem = this._generator.GetNewItem();
                modelBuilder.Entity<KartItem>().HasData(kartItem);
            }
        }
    }
}
