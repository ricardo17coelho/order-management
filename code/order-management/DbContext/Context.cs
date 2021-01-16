﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;


namespace order_management
{
    public class Context : DbContext
    {
        public DbSet<Customer> Customers { get; set; }
        public DbSet<ProductCategory> ProductCategories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=.; Database=dbName15; Trusted_Connection=True");

            //For Debugging
            //optionsBuilder.LogTo(Console.WriteLine); 
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<ProductCategory>()
            //.OnDelete(DeleteBehavior.Restrict); // TODO: Rekursives löschen

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

            customers.ForEach(customer => modelBuilder.Entity<Customer>().HasData(customer));
            categories.ForEach(category => modelBuilder.Entity<ProductCategory>().HasData(category));
            products.ForEach(product => modelBuilder.Entity<Product>().HasData(product));

        }
    }
}
