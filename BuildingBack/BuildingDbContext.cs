using BuildingBack.Models;
using Microsoft.EntityFrameworkCore;

namespace BuildingBack
{
    public class BuildingDbContext : DbContext
    {
        public BuildingDbContext(DbContextOptions<BuildingDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Building>().HasKey(e => e.Id);
            modelBuilder.Entity<Object>().HasKey(e => e.Id);
            modelBuilder.Entity<DataField>().HasKey(e => e.Id);
            modelBuilder.Entity<Reading>().HasKey(e => e.Id);
        }

        public DbSet<Building> Building { get; set; }
        public DbSet<Object> Object { get; set; }
        public DbSet<DataField> DataField { get; set; }
        public DbSet<Reading> Reading { get; set; }
    }
}
