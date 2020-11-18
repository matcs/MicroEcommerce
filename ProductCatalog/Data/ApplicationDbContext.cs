using Microsoft.EntityFrameworkCore;
using ProductCatalog.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductCatalog.Data
{
    public class ApplicationDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder
               .UseSqlServer("Server=localhost\\SQLEXPRESS;Database=CatalogDb;Trusted_Connection=True;",
               providerOptions => providerOptions.CommandTimeout(100));
        }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        { }

        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Product>().HasData(
                new Product()
                {
                    ProductId = 1,
                    Name = "Cadeira da jantar",
                    Description = "Uma cadeira feita para jantar",
                    Image = Product.ReadFile("Images\\chair.jpg")
                },
                new Product()
                {
                    ProductId = 2,
                    Name = "Cadeira gamer",
                    Description = "Uma cadeira feita para jogar",
                    Image = Product.ReadFile("Images\\gamer-chair.jpg")
                },
                new Product()
                {
                    ProductId = 3,
                    Name = "Cadeira de varanda",
                    Description = "Uma cadeira feita para por na varanda",
                    Image = Product.ReadFile("Images\\chair-varanda.jpg")
                },
                new Product()
                {
                    ProductId = 4,
                    Name = "Cadeira de escritorio",
                    Description = "Uma cadeira feita para por no escritorio",
                    Image = Product.ReadFile("Images\\chair-escritorio.jpg")
                });


        }
    }
}
