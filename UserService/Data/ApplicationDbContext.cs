using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UserService.Models;

namespace UserService.Data
{
    public class ApplicationDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder
               .UseSqlServer("Server=localhost\\SQLEXPRESS;Database=MicroEcommerce_DB;Trusted_Connection=True;",
               providerOptions => providerOptions.CommandTimeout(100));
        }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        { }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<CreditCard> CreditCards { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Customer>().HasData(
                new Customer()
                {
                    CustomerId=1,
                    Email="saiuhia@outlook.com",
                    Password="passs",
                    Name="Dimitri",
                    LastName="Vegas"
                },
                new Customer()
                {
                    CustomerId=2,
                    Email="kdljfslkds@gmail.com",
                    Password="hee-hee",
                    Name="Mike",
                    LastName="Uatzolski"
                });
        }

    }
}
