﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using order_management;

namespace order_management.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20210116131314_Catefjilsdfsdfjdfkdsfsdfdf")]
    partial class Catefjilsdfsdfjdfkdsfsdfdf
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("order_management.Customer", b =>
                {
                    b.Property<int>("CustomerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Country")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Street")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StreetNr")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Zip")
                        .HasColumnType("int");

                    b.HasKey("CustomerId");

                    b.ToTable("Customers");

                    b.HasData(
                        new
                        {
                            CustomerId = 1000,
                            City = "Wil",
                            Country = "Schweiz",
                            FirstName = "Hans",
                            LastName = "Müller",
                            Street = "Bahnhofstrasse",
                            StreetNr = "12a",
                            Zip = 9400
                        },
                        new
                        {
                            CustomerId = 1001,
                            City = "Uznach",
                            Country = "Schweiz",
                            FirstName = "Peter",
                            LastName = "Haller",
                            Street = "Dorfstrasse",
                            StreetNr = "5",
                            Zip = 8452
                        },
                        new
                        {
                            CustomerId = 1002,
                            City = "Zuckenriet",
                            Country = "Schweiz",
                            FirstName = "Ueli",
                            LastName = "Moser",
                            Street = "Lindenstrasse",
                            StreetNr = "27",
                            Zip = 4524
                        },
                        new
                        {
                            CustomerId = 1003,
                            City = "Schlieren",
                            Country = "Schweiz",
                            FirstName = "Max",
                            LastName = "Mustermann",
                            Street = "Bachweg",
                            StreetNr = "1a",
                            Zip = 4582
                        },
                        new
                        {
                            CustomerId = 1004,
                            City = "Walden",
                            Country = "Schweiz",
                            FirstName = "Vreni",
                            LastName = "Kuster",
                            Street = "Hinter dem Baum",
                            StreetNr = "12",
                            Zip = 4521
                        },
                        new
                        {
                            CustomerId = 1005,
                            City = "Ederswiler",
                            Country = "Schweiz",
                            FirstName = "Petra",
                            LastName = "Schwarz",
                            Street = "Blumenstrasse",
                            StreetNr = "45b",
                            Zip = 1234
                        },
                        new
                        {
                            CustomerId = 1006,
                            City = "Spreitebach",
                            Country = "Schweiz",
                            FirstName = "Andreas",
                            LastName = "Rot",
                            Street = "Bahnhofplatz",
                            StreetNr = "13",
                            Zip = 9452
                        },
                        new
                        {
                            CustomerId = 1007,
                            City = "Mörschwil",
                            Country = "Schweiz",
                            FirstName = "Jürgen",
                            LastName = "Blyatman",
                            Street = "Huebstrasse",
                            StreetNr = "16",
                            Zip = 9152
                        },
                        new
                        {
                            CustomerId = 1008,
                            City = "Interlaken",
                            Country = "Schweiz",
                            FirstName = "Oskar",
                            LastName = "Kanban",
                            Street = "Rosenweg",
                            StreetNr = "1b",
                            Zip = 8523
                        },
                        new
                        {
                            CustomerId = 1009,
                            City = "Flieren",
                            Country = "Schweiz",
                            FirstName = "Karin",
                            LastName = "Blattsalat",
                            Street = "Bachfeldstrasse",
                            StreetNr = "5",
                            Zip = 5423
                        });
                });

            modelBuilder.Entity("order_management.Order", b =>
                {
                    b.Property<int>("OrderId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("CustomerId")
                        .HasColumnType("int");

                    b.Property<DateTime>("OrderDate")
                        .HasColumnType("datetime2");

                    b.Property<double>("Tax")
                        .HasColumnType("float");

                    b.HasKey("OrderId");

                    b.HasIndex("CustomerId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("order_management.OrderDetail", b =>
                {
                    b.Property<int>("OrderDetailId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("OrderId")
                        .HasColumnType("int");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("OrderDetailId");

                    b.HasIndex("OrderId");

                    b.HasIndex("ProductId");

                    b.ToTable("OrderDetails");
                });

            modelBuilder.Entity("order_management.Product", b =>
                {
                    b.Property<int>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<int?>("ProductCategoryId")
                        .HasColumnType("int");

                    b.Property<string>("ProductName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Unit")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ProductId");

                    b.HasIndex("ProductCategoryId");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("order_management.ProductCategory", b =>
                {
                    b.Property<int>("ProductCategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int?>("ParentId")
                        .HasColumnType("int");

                    b.Property<string>("ProductCategoryName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ProductCategoryId");

                    b.HasIndex("ParentId");

                    b.ToTable("ProductCategories");

                    b.HasData(
                        new
                        {
                            ProductCategoryId = 1000,
                            ProductCategoryName = "Computer Equipment"
                        },
                        new
                        {
                            ProductCategoryId = 1001,
                            ParentId = 1000,
                            ProductCategoryName = "Monitors"
                        },
                        new
                        {
                            ProductCategoryId = 1002,
                            ParentId = 1001,
                            ProductCategoryName = "Curved"
                        },
                        new
                        {
                            ProductCategoryId = 1003,
                            ParentId = 1000,
                            ProductCategoryName = "Keyboards"
                        },
                        new
                        {
                            ProductCategoryId = 1004,
                            ProductCategoryName = "Furniture"
                        },
                        new
                        {
                            ProductCategoryId = 1005,
                            ParentId = 1004,
                            ProductCategoryName = "Tables"
                        },
                        new
                        {
                            ProductCategoryId = 1006,
                            ParentId = 1004,
                            ProductCategoryName = "Chairs"
                        },
                        new
                        {
                            ProductCategoryId = 1007,
                            ParentId = 1006,
                            ProductCategoryName = "Office Chairs"
                        });
                });

            modelBuilder.Entity("order_management.Order", b =>
                {
                    b.HasOne("order_management.Customer", "Customer")
                        .WithMany()
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customer");
                });

            modelBuilder.Entity("order_management.OrderDetail", b =>
                {
                    b.HasOne("order_management.Order", "Order")
                        .WithMany()
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("order_management.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Order");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("order_management.Product", b =>
                {
                    b.HasOne("order_management.ProductCategory", "ProductCategory")
                        .WithMany()
                        .HasForeignKey("ProductCategoryId");

                    b.Navigation("ProductCategory");
                });

            modelBuilder.Entity("order_management.ProductCategory", b =>
                {
                    b.HasOne("order_management.ProductCategory", "Parent")
                        .WithMany()
                        .HasForeignKey("ParentId");

                    b.Navigation("Parent");
                });
#pragma warning restore 612, 618
        }
    }
}
