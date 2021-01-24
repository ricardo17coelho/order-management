using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using order_management.DbModels;


namespace order_management
{
    public class Context : DbContext
    {
        public DbSet<Customer> Customers { get; set; }
        public DbSet<ProductCategory> ProductCategories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<YoyComparison> YoyComparisons { get; set; }
        public DbSet<Bill> Bills { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=.; Database=dbName31; Trusted_Connection=True");

            //For Debugging
            //optionsBuilder.LogTo(Console.WriteLine); 
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<YoyComparison>()
                .HasNoKey()
                .ToView(null);

            modelBuilder.Entity<Bill>()
                .HasNoKey()
                .ToView(null);

            List<Customer> customers = new List<Customer>
            {
                new Customer(1000, "Hans", "Müller", "Bahnhofstrasse", "12a", 9400, "Wil", "Schweiz"),
                new Customer(1001, "Peter", "Haller", "Dorfstrasse", "5", 8452, "Uznach", "Schweiz"),
                new Customer(1002, "Ueli", "Moser", "Lindenstrasse", "27", 4524, "Zuckenriet", "Schweiz"),
                new Customer(1003,"Max", "Mustermann", "Bachweg", "1a", 4582, "Schlieren", "Schweiz"),
                new Customer(1004, "Vreni", "Kuster", "Hinter dem Baum", "12", 4521, "Walden", "Schweiz"),
                new Customer(1005, "Petra", "Schwarz", "Blumenstrasse", "45b", 1234, "Ederswiler", "Schweiz"),
                new Customer(1006, "Andreas", "Rot", "Bahnhofplatz", "13", 9452, "Spreitebach", "Schweiz"),
                new Customer(1007, "Jürgen", "Blyatman", "Huebstrasse", "16", 9152, "Mörschwil", "Schweiz"),
                new Customer(1008, "Oskar", "Kanban", "Rosenweg", "1b", 8523, "Interlaken", "Schweiz"),
                new Customer(1009, "Karin", "Blattsalat", "Bachfeldstrasse", "5", 5423, "Flieren", "Schweiz")
            };

            List<ProductCategory> categories = new List<ProductCategory>
            {
                new ProductCategory(1000, "Computer Equipment"),
                new ProductCategory(1001, "Monitors", 1000),
                new ProductCategory(1002, "Curved", 1001),
                new ProductCategory(1003, "Keyboards", 1000),
                new ProductCategory(1004, "Furniture"),
                new ProductCategory(1005, "Tables", 1004),
                new ProductCategory(1006, "Chairs", 1004),
                new ProductCategory(1007, "Office Chairs", 1006)
            };

            List<Product> products = new List<Product>
            {
                new Product(1000, "HP Compaq 24 Inch", 300, "Fr.", new DateTime(2018, 11, 15), 1000),
                new Product(1001, "Samsung 49HG90 49 Inch", 899, "Fr.", new DateTime(2019, 11, 15), 1001),
                new Product(1002, "Logitech Ergonomic", 60, "Fr.", new DateTime(2020, 11, 15), 1003),
                new Product(1003, "Super Chair 2000", 1200, "Fr.", new DateTime(2019, 1, 15), 1006),
                new Product(1004, "Bad Chaur 100", 50, "Fr.", new DateTime(2018, 11, 15), 1006),
                new Product(1005, "Nitro Concepts 300", 7000, "Fr.", new DateTime(2019, 11, 15), 1007),
                new Product(1006, "Samsung super Curved Monitor 30 Inch", 300, "Fr.", new DateTime(2019, 7, 15), 1002),
                new Product(1007, "Super Table", 2000, "Fr.", new DateTime(2018, 5, 15), 1005),
                new Product(1008, "Bad Table", 250, "Fr.", new DateTime(2018, 5, 15), 1005),
            };

            List<Order> orders = new List<Order>
            {
                new Order(1000,1000, new DateTime(2018, 1, 15)),
                new Order(1001,1000, new DateTime(2019, 5, 15)),
                new Order(1002,1001, new DateTime(2020, 8, 15)),
                new Order(1003,1001, new DateTime(2019, 12, 15)),
                new Order(1004,1001, new DateTime(2018, 1, 15)),
                new Order(1005,1003, new DateTime(2020, 5, 15)),
                new Order(1006,1004, new DateTime(2019, 9, 15)),
                new Order(1007,1005, new DateTime(2018, 12, 15)),
                new Order(1008,1006, new DateTime(2020, 1, 15)),
                new Order(1009,1007, new DateTime(2020, 1, 15)),
                new Order(1010,1008, new DateTime(2019, 12, 15)),
            };

            List<OrderDetail> orderDetails = new List<OrderDetail>
            {
                new OrderDetail(1000, 2, 1000, 1001),
                new OrderDetail(1001, 4, 1000, 1004),
                new OrderDetail(1002, 4, 1000, 1005),
                new OrderDetail(1003, 1, 1000, 1002),
                new OrderDetail(1004, 2, 1000, 1003),
                new OrderDetail(1005, 1, 1001, 1008),
                new OrderDetail(1006, 4, 1001, 1001),
                new OrderDetail(1007, 3, 1002, 1003),
                new OrderDetail(1008, 12, 1002, 1004),
                new OrderDetail(1009, 2, 1003, 1004),
                new OrderDetail(1010, 1, 1003, 1005),
                new OrderDetail(1011, 5, 1003, 1006),
                new OrderDetail(1012, 2, 1004, 1007),
                new OrderDetail(1013, 1, 1004, 1008),
                new OrderDetail(1014, 3, 1004, 1008),
                new OrderDetail(1015, 4, 1005, 1002),
                new OrderDetail(1016, 5, 1005, 1001),
                new OrderDetail(1017, 1, 1005, 1001),
                new OrderDetail(1018, 2, 1005, 1006),
                new OrderDetail(1019, 4, 1006, 1001),
                new OrderDetail(1020, 1, 1006, 1002),
                new OrderDetail(1021, 2, 1007, 1003),
                new OrderDetail(1022, 4, 1007, 1004),
                new OrderDetail(1023, 3, 1007, 1008),
                new OrderDetail(1024, 1, 1008, 1001),
                new OrderDetail(1025, 12, 1009, 1002),
                new OrderDetail(1026, 1, 1009, 1004),
                new OrderDetail(1027, 64, 1010, 1003),
                new OrderDetail(1028, 1, 1010, 1006),
                new OrderDetail(1029, 2, 1010, 1001),
                new OrderDetail(1030, 4, 1010, 1007)
            };

            customers.ForEach(customer => modelBuilder.Entity<Customer>().HasData(customer));
            categories.ForEach(category => modelBuilder.Entity<ProductCategory>().HasData(category));
            products.ForEach(product => modelBuilder.Entity<Product>().HasData(product));
            orders.ForEach(order => modelBuilder.Entity<Order>().HasData(order));
            orderDetails.ForEach(orderDetail => modelBuilder.Entity<OrderDetail>().HasData(orderDetail));
        }
    }
}
