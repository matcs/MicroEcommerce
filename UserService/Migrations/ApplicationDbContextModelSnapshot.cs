﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using UserService.Data;

namespace UserService.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("UserService.Models.CreditCard", b =>
                {
                    b.Property<int>("CreditCardId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("CreditCardBrand")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CustomerId")
                        .HasColumnType("int");

                    b.Property<string>("Cvv")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ExpirationDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("HolderName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Number")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CreditCardId");

                    b.HasIndex("CustomerId");

                    b.ToTable("CreditCards");

                    b.HasData(
                        new
                        {
                            CreditCardId = 1,
                            CreditCardBrand = "Master",
                            CustomerId = 1,
                            Cvv = "332",
                            ExpirationDate = new DateTime(2020, 11, 18, 16, 0, 4, 986, DateTimeKind.Utc).AddTicks(205),
                            HolderName = "MIKE WATZOLSKI",
                            Number = "46546565465465"
                        });
                });

            modelBuilder.Entity("UserService.Models.Customer", b =>
                {
                    b.Property<int>("CustomerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CustomerId");

                    b.ToTable("Customers");

                    b.HasData(
                        new
                        {
                            CustomerId = 1,
                            Email = "saiuhia@outlook.com",
                            LastName = "Vegas",
                            Name = "Dimitri",
                            Password = "passs"
                        },
                        new
                        {
                            CustomerId = 2,
                            Email = "kdljfslkds@gmail.com",
                            LastName = "Uatzolski",
                            Name = "Mike",
                            Password = "hee-hee"
                        });
                });

            modelBuilder.Entity("UserService.Models.PurchasesHistoric", b =>
                {
                    b.Property<int>("PurchasesHistoricId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("CustomerId")
                        .HasColumnType("int");

                    b.Property<int>("PurchasesItemId")
                        .HasColumnType("int");

                    b.HasKey("PurchasesHistoricId");

                    b.HasIndex("CustomerId");

                    b.ToTable("PurchasesHistoric");

                    b.HasData(
                        new
                        {
                            PurchasesHistoricId = 1,
                            CustomerId = 1,
                            PurchasesItemId = 1
                        },
                        new
                        {
                            PurchasesHistoricId = 2,
                            CustomerId = 1,
                            PurchasesItemId = 2
                        });
                });

            modelBuilder.Entity("UserService.Models.CreditCard", b =>
                {
                    b.HasOne("UserService.Models.Customer", "Customer")
                        .WithMany("CreditCards")
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customer");
                });

            modelBuilder.Entity("UserService.Models.PurchasesHistoric", b =>
                {
                    b.HasOne("UserService.Models.Customer", "Customer")
                        .WithMany("PurchasesHistorics")
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customer");
                });

            modelBuilder.Entity("UserService.Models.Customer", b =>
                {
                    b.Navigation("CreditCards");

                    b.Navigation("PurchasesHistorics");
                });
#pragma warning restore 612, 618
        }
    }
}
