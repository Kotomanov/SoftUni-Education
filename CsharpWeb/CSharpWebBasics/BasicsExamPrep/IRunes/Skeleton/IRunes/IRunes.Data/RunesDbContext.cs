namespace IRunes.Data
{
    using IRunes.Models;
    using Microsoft.EntityFrameworkCore;

    public class RunesDbContext : DbContext
    {
        // TODO

        public DbSet<User> Users { get; set; }

        public DbSet<Album> Albums { get; set; }    
        public DbSet<Track> Tracks { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(@"Server=DESKTOP-1SHT5A0\SQLEXPRESS;Database=IRunes;Trusted_Connection=True");
                //ConnectionString = @"Server=DESKTOP-1SHT5A0\SQLEXPRESS;Database=TeisterMask;Trusted_Connection=True";
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
