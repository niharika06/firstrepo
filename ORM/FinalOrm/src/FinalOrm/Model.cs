using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;


namespace FinalOrm
{
    public class Model : DbContext          
    {
        public DbSet<Product> Product { get; set; }
        public DbSet<Updates> Updates { get; set; }
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=MyDatabase;");
        }

        

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
           // modelBuilder.Entity<Product>()
           //     .Property(b => b.ProdId)
               //     .IsRequired();

        }
    }
}
