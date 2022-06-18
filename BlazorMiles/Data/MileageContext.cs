using Microsoft.EntityFrameworkCore;

namespace BlazorMiles.Data
{
    public class MileageContext : DbContext 
    {
        public MileageContext(DbContextOptions options) :base(options)
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<MilesGallon>()
             .Property(b => b.Miles)
             .HasPrecision(18, 2);
            modelBuilder.Entity<MilesGallon>()
             .Property(b => b.Gallons)
             .HasPrecision(18, 2);
        }
        public DbSet<MilesGallon> MilesGallons { get; set; }
    }
}
