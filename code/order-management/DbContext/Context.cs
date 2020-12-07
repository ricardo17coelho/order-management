using Microsoft.EntityFrameworkCore;
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

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=.; Database=dbName5; Trusted_Connection=True");

            //For Debugging
            //optionsBuilder.LogTo(Console.WriteLine); 
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Customer testPerson = new Customer("Mike", "Smith", "FooStreet", "5b", 6666, "Saint City", "Italy");
            //testPerson.CustomerId = 1;

            //ProductCategory testProductCategory = new ProductCategory("Monitors");

            //Product testProduct = new Product("HP Compaq", 299.95, "Fr.", testProductCategory);
            //modelBuilder.Entity<Customer>().HasData(testPerson);
            //modelBuilder.Entity<ProductCategory>().HasData(testProductCategory);
            //modelBuilder.Entity<Product>().HasData(testProduct);
        }
    }
}
