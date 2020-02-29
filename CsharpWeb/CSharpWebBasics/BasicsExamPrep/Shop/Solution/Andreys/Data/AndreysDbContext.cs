namespace Andreys.Data
{
    using Andreys.Models;
    using Microsoft.EntityFrameworkCore;

    public class AndreysDbContext : DbContext
    {
        //set connection string
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder
                    .UseSqlServer(@"Server=DESKTOP-1SHT5A0\SQLEXPRESS;Database=AndreysDb;Integrated Security=True");
            }
        }

        //TODO add Dbsets 

        public DbSet<User> Users { get; set; }

        public DbSet<Product> Products  { get; set; }
    }
}
