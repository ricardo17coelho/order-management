using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace order_management
{
    public class CustomerService
    {

        public List<Customer> GetAll()
        {
            using (var context = new Context())
            {
                return context.Customers.ToList();
            }
        }

        public Customer GetByName(string firstName, string lastName)
        {
            using (var context = new Context())
            {
                return context.Customers
                .Where(c => (c.FirstName == firstName && c.LastName == lastName))
                .FirstOrDefault<Customer>();
            }
        }

        public void Add(Customer customer)
        {
            using (var context = new Context())
            {
                context.Customers.Attach(customer);
                context.SaveChanges();
            }
        }

        public void Update(Customer oldCustomer, Customer newCustomer)
        {
            using (var context = new Context())
            {
                Customer entity = GetByName(oldCustomer.FirstName, oldCustomer.LastName);

                if (entity != null)
                {
                    entity.FirstName = newCustomer.FirstName;
                    entity.LastName = newCustomer.LastName;
                    entity.Street = newCustomer.Street;
                    entity.StreetNr = newCustomer.StreetNr;
                    entity.Zip = newCustomer.Zip;
                    entity.City = newCustomer.City;
                    entity.Country = newCustomer.Country;

                    var attach = context.Customers.Attach(entity);
                    attach.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                    context.SaveChanges();
                }
            }
        }

        public void Delete(Customer customer)
        {
            using (var context = new Context()) 
            { 
                context.Customers.Remove(customer);
                context.SaveChanges();
            }
        }

        public List<Customer> Search(string searchString)
        {
            searchString = searchString.ToLower();

            using (var context = new Context())
            {
                return context.Customers
                    .Where(customer =>
                        customer.FirstName.ToLower().Contains(searchString) ||
                        customer.LastName.ToLower().Contains(searchString) ||
                        customer.Street.ToLower().Contains(searchString) ||
                        customer.Zip.ToString().Contains(searchString) ||
                        customer.City.ToLower().Contains(searchString) ||
                        customer.Country.ToLower().Contains(searchString)
                    ).ToList();
            }
        }

        public Boolean IsUnique(Customer customer)
        {
            using (var context = new Context())
            {
                return !context.Customers
                .Any(c => (c.FirstName == customer.FirstName) &&
                  (c.LastName == customer.LastName));
            }
        }

        public Boolean IsValid(Customer customer)
        {
            return customer.FirstName != "" &&
              customer.LastName != "";
        }
    }
}
