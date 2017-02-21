using Microsoft.EntityFrameworkCore;

namespace MYOrmDemo
{
    public class Model : DbContext
    {
        public DbSet<Product> Product { get; set; }
        public DbSet<Updates> Updates { get; set; }
        public object Id { get; internal set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=localdb\mssqllocaldb;Database=MyDatabase.ConsoleApp.NewDb;Trusted_Connect");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>()
                .Property(b => b.Id)
                    .IsRequired();

        }
    }
}


