using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace order_management
{
    public class CustomerService : DbService
    {
        public static BindingList<Customer> GetBoundedList(Context context)
        {
            context.Customers.Load();
            return context.Customers.Local.ToBindingList();
        }

        public static void Add(Context context, Customer customer)
        {
            context.Customers.Add(customer);
            context.SaveChanges();
        }

        public static void Remove(Context context, Customer customer)
        {
            context.Customers.Remove(customer);
            context.SaveChanges();
        }

        public static void RemoveAll(Context context)
        {
            context.Customers.RemoveRange(context.Customers);
            context.SaveChanges();
        }



        public static Boolean IsUnique(Context context, Customer customer)
        {
            return !context.Customers
                .Any(c => (c.FirstName == customer.FirstName) &&
                  (c.LastName == customer.LastName));
        }

        public static Boolean IsValid(Context context, Customer customer)
        {
            return customer.FirstName != "" &&
              customer.LastName != "";
        }

        public static Customer GetEntityByName(Context context, string firstName, string lastName)
        {
            return context.Customers
            .Where(c => (c.FirstName == firstName && c.LastName == c.LastName))
            .FirstOrDefault<Customer>();
        }

        public static Customer GetEntityById(Context context, int id)
        {
            return context.Customers.Find(id);
        }
    }
}
