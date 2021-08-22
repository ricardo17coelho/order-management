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
    [Migration("20210205095823_order-management")]
    partial class ordermanagement
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

            modelBuilder.Entity("order_management.DbModels.Bill", b =>
                {
                    b.Property<int>("BillId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<double>("Brutto")
                        .HasColumnType("float");

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Country")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CustomerId")
                        .HasColumnType("int");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Netto")
                        .HasColumnType("float");

                    b.Property<DateTime>("OrderDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("OrderId")
                        .HasColumnType("int");

                    b.Property<string>("Street")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StreetNr")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Zip")
                        .HasColumnType("int");

                    b.HasKey("BillId");

                    b.ToTable("Bills");

                    b.HasData(
                        new
                        {
                            BillId = 1000,
                            Brutto = 107.7,
                            City = "Wil",
                            Country = "Schweiz",
                            CustomerId = 1000,
                            FirstName = "Hans",
                            LastName = "Müller",
                            Netto = 100.0,
                            OrderDate = new DateTime(2018, 11, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            OrderId = 1000,
                            Street = "Bahnhofstrasse",
                            StreetNr = "12a",
                            Zip = 9400
                        },
                        new
                        {
                            BillId = 1001,
                            Brutto = 215.19999999999999,
                            City = "Wil",
                            Country = "Schweiz",
                            CustomerId = 1000,
                            FirstName = "Hans",
                            LastName = "Müller",
                            Netto = 200.0,
                            OrderDate = new DateTime(2020, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            OrderId = 1005,
                            Street = "Bahnhofstrasse",
                            StreetNr = "12a",
                            Zip = 9400
                        },
                        new
                        {
                            BillId = 1002,
                            Brutto = 100.0,
                            City = "Uznach",
                            Country = "Schweiz",
                            CustomerId = 1001,
                            FirstName = "Peter",
                            LastName = "Haller",
                            Netto = 75.0,
                            OrderDate = new DateTime(2019, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            OrderId = 1004,
                            Street = "Dorfstrasse",
                            StreetNr = "5",
                            Zip = 8452
                        },
                        new
                        {
                            BillId = 1003,
                            Brutto = 57.5,
                            City = "Uznach",
                            Country = "Schweiz",
                            CustomerId = 1001,
                            FirstName = "Peter",
                            LastName = "Haller",
                            Netto = 50.0,
                            OrderDate = new DateTime(2020, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            OrderId = 1002,
                            Street = "Dorfstrasse",
                            StreetNr = "5",
                            Zip = 8452
                        },
                        new
                        {
                            BillId = 1004,
                            Brutto = 80.5,
                            City = "Zuckenriet",
                            Country = "Schweiz",
                            CustomerId = 1002,
                            FirstName = "Ueli",
                            LastName = "Moser",
                            Netto = 75.0,
                            OrderDate = new DateTime(2020, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            OrderId = 1007,
                            Street = "Lindenstrasse",
                            StreetNr = "27",
                            Zip = 4524
                        });
                });

            modelBuilder.Entity("order_management.DbModels.YoyComparison", b =>
                {
                    b.Property<int>("AvgCountProductsPerOrder")
                        .HasColumnType("int");

                    b.Property<int>("CountOrders")
                        .HasColumnType("int");

                    b.Property<string>("Quarter")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("TotalRevenue")
                        .HasColumnType("float");
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

                    b.HasData(
                        new
                        {
                            OrderId = 1000,
                            CustomerId = 1000,
                            OrderDate = new DateTime(2018, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Tax = 7.7000000000000002
                        },
                        new
                        {
                            OrderId = 1001,
                            CustomerId = 1000,
                            OrderDate = new DateTime(2019, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Tax = 7.7000000000000002
                        },
                        new
                        {
                            OrderId = 1002,
                            CustomerId = 1001,
                            OrderDate = new DateTime(2020, 8, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Tax = 7.7000000000000002
                        },
                        new
                        {
                            OrderId = 1003,
                            CustomerId = 1001,
                            OrderDate = new DateTime(2019, 12, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Tax = 7.7000000000000002
                        },
                        new
                        {
                            OrderId = 1004,
                            CustomerId = 1001,
                            OrderDate = new DateTime(2018, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Tax = 7.7000000000000002
                        },
                        new
                        {
                            OrderId = 1005,
                            CustomerId = 1003,
                            OrderDate = new DateTime(2020, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Tax = 7.7000000000000002
                        },
                        new
                        {
                            OrderId = 1006,
                            CustomerId = 1004,
                            OrderDate = new DateTime(2019, 9, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Tax = 7.7000000000000002
                        },
                        new
                        {
                            OrderId = 1007,
                            CustomerId = 1005,
                            OrderDate = new DateTime(2018, 12, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Tax = 7.7000000000000002
                        },
                        new
                        {
                            OrderId = 1008,
                            CustomerId = 1006,
                            OrderDate = new DateTime(2020, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Tax = 7.7000000000000002
                        },
                        new
                        {
                            OrderId = 1009,
                            CustomerId = 1007,
                            OrderDate = new DateTime(2020, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Tax = 7.7000000000000002
                        },
                        new
                        {
                            OrderId = 1010,
                            CustomerId = 1008,
                            OrderDate = new DateTime(2019, 12, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Tax = 7.7000000000000002
                        });
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

                    b.HasData(
                        new
                        {
                            OrderDetailId = 1000,
                            OrderId = 1000,
                            ProductId = 1001,
                            Quantity = 2
                        },
                        new
                        {
                            OrderDetailId = 1001,
                            OrderId = 1000,
                            ProductId = 1004,
                            Quantity = 4
                        },
                        new
                        {
                            OrderDetailId = 1002,
                            OrderId = 1000,
                            ProductId = 1005,
                            Quantity = 4
                        },
                        new
                        {
                            OrderDetailId = 1003,
                            OrderId = 1000,
                            ProductId = 1002,
                            Quantity = 1
                        },
                        new
                        {
                            OrderDetailId = 1004,
                            OrderId = 1000,
                            ProductId = 1003,
                            Quantity = 2
                        },
                        new
                        {
                            OrderDetailId = 1005,
                            OrderId = 1001,
                            ProductId = 1008,
                            Quantity = 1
                        },
                        new
                        {
                            OrderDetailId = 1006,
                            OrderId = 1001,
                            ProductId = 1001,
                            Quantity = 4
                        },
                        new
                        {
                            OrderDetailId = 1007,
                            OrderId = 1002,
                            ProductId = 1003,
                            Quantity = 3
                        },
                        new
                        {
                            OrderDetailId = 1008,
                            OrderId = 1002,
                            ProductId = 1004,
                            Quantity = 12
                        },
                        new
                        {
                            OrderDetailId = 1009,
                            OrderId = 1003,
                            ProductId = 1004,
                            Quantity = 2
                        },
                        new
                        {
                            OrderDetailId = 1010,
                            OrderId = 1003,
                            ProductId = 1005,
                            Quantity = 1
                        },
                        new
                        {
                            OrderDetailId = 1011,
                            OrderId = 1003,
                            ProductId = 1006,
                            Quantity = 5
                        },
                        new
                        {
                            OrderDetailId = 1012,
                            OrderId = 1004,
                            ProductId = 1007,
                            Quantity = 2
                        },
                        new
                        {
                            OrderDetailId = 1013,
                            OrderId = 1004,
                            ProductId = 1008,
                            Quantity = 1
                        },
                        new
                        {
                            OrderDetailId = 1014,
                            OrderId = 1004,
                            ProductId = 1008,
                            Quantity = 3
                        },
                        new
                        {
                            OrderDetailId = 1015,
                            OrderId = 1005,
                            ProductId = 1002,
                            Quantity = 4
                        },
                        new
                        {
                            OrderDetailId = 1016,
                            OrderId = 1005,
                            ProductId = 1001,
                            Quantity = 5
                        },
                        new
                        {
                            OrderDetailId = 1017,
                            OrderId = 1005,
                            ProductId = 1001,
                            Quantity = 1
                        },
                        new
                        {
                            OrderDetailId = 1018,
                            OrderId = 1005,
                            ProductId = 1006,
                            Quantity = 2
                        },
                        new
                        {
                            OrderDetailId = 1019,
                            OrderId = 1006,
                            ProductId = 1001,
                            Quantity = 4
                        },
                        new
                        {
                            OrderDetailId = 1020,
                            OrderId = 1006,
                            ProductId = 1002,
                            Quantity = 1
                        },
                        new
                        {
                            OrderDetailId = 1021,
                            OrderId = 1007,
                            ProductId = 1003,
                            Quantity = 2
                        },
                        new
                        {
                            OrderDetailId = 1022,
                            OrderId = 1007,
                            ProductId = 1004,
                            Quantity = 4
                        },
                        new
                        {
                            OrderDetailId = 1023,
                            OrderId = 1007,
                            ProductId = 1008,
                            Quantity = 3
                        },
                        new
                        {
                            OrderDetailId = 1024,
                            OrderId = 1008,
                            ProductId = 1001,
                            Quantity = 1
                        },
                        new
                        {
                            OrderDetailId = 1025,
                            OrderId = 1009,
                            ProductId = 1002,
                            Quantity = 12
                        },
                        new
                        {
                            OrderDetailId = 1026,
                            OrderId = 1009,
                            ProductId = 1004,
                            Quantity = 1
                        },
                        new
                        {
                            OrderDetailId = 1027,
                            OrderId = 1010,
                            ProductId = 1003,
                            Quantity = 64
                        },
                        new
                        {
                            OrderDetailId = 1028,
                            OrderId = 1010,
                            ProductId = 1006,
                            Quantity = 1
                        },
                        new
                        {
                            OrderDetailId = 1029,
                            OrderId = 1010,
                            ProductId = 1001,
                            Quantity = 2
                        },
                        new
                        {
                            OrderDetailId = 1030,
                            OrderId = 1010,
                            ProductId = 1007,
                            Quantity = 4
                        });
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

                    b.Property<int>("ProductCategoryId")
                        .HasColumnType("int");

                    b.Property<string>("ProductName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Unit")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ProductId");

                    b.HasIndex("ProductCategoryId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            ProductId = 1000,
                            Date = new DateTime(2018, 11, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Price = 300.0,
                            ProductCategoryId = 1000,
                            ProductName = "HP Compaq 24 Inch",
                            Unit = "Fr."
                        },
                        new
                        {
                            ProductId = 1001,
                            Date = new DateTime(2019, 11, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Price = 899.0,
                            ProductCategoryId = 1001,
                            ProductName = "Samsung 49HG90 49 Inch",
                            Unit = "Fr."
                        },
                        new
                        {
                            ProductId = 1002,
                            Date = new DateTime(2020, 11, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Price = 60.0,
                            ProductCategoryId = 1003,
                            ProductName = "Logitech Ergonomic",
                            Unit = "Fr."
                        },
                        new
                        {
                            ProductId = 1003,
                            Date = new DateTime(2019, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Price = 1200.0,
                            ProductCategoryId = 1006,
                            ProductName = "Super Chair 2000",
                            Unit = "Fr."
                        },
                        new
                        {
                            ProductId = 1004,
                            Date = new DateTime(2018, 11, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Price = 50.0,
                            ProductCategoryId = 1006,
                            ProductName = "Bad Chaur 100",
                            Unit = "Fr."
                        },
                        new
                        {
                            ProductId = 1005,
                            Date = new DateTime(2019, 11, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Price = 7000.0,
                            ProductCategoryId = 1007,
                            ProductName = "Nitro Concepts 300",
                            Unit = "Fr."
                        },
                        new
                        {
                            ProductId = 1006,
                            Date = new DateTime(2019, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Price = 300.0,
                            ProductCategoryId = 1002,
                            ProductName = "Samsung super Curved Monitor 30 Inch",
                            Unit = "Fr."
                        },
                        new
                        {
                            ProductId = 1007,
                            Date = new DateTime(2018, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Price = 2000.0,
                            ProductCategoryId = 1005,
                            ProductName = "Super Table",
                            Unit = "Fr."
                        },
                        new
                        {
                            ProductId = 1008,
                            Date = new DateTime(2018, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Price = 250.0,
                            ProductCategoryId = 1005,
                            ProductName = "Bad Table",
                            Unit = "Fr."
                        });
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
                        .HasForeignKey("ProductCategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

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