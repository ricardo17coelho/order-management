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

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=.; Database=dbName; Trusted_Connection=True");

            //For Debugging
            //optionsBuilder.LogTo(Console.WriteLine); 
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            Customer testPerson = new Customer(1, "Mike", "Smith", "FooStreet", "5b", 6666, "Saint City", "Italy");
            modelBuilder.Entity<Customer>().HasData(testPerson);
        }
    }
}
