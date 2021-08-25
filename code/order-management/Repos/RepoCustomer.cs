using System;
using System.Collections.Generic;
using System.Linq;

namespace order_management
{
    public class RepoCustomer : RepoBase<Customer>
    {

        public RepoCustomer(OrderManagementDbContext orderManagementDbContext) : base(orderManagementDbContext)
        {
            
        }

        public virtual Customer GetByName(string firstName, string lastName)
        {
                return _orderManagementDbContext.Customers
                .Where(c => (c.FirstName == firstName && c.LastName == lastName))
                .FirstOrDefault<Customer>();
        }

        public virtual List<Customer> Search(string searchString)
        {
            searchString = searchString.ToLower();

            var table = _orderManagementDbContext.Set<Customer>();

            return table
            .Where(customer =>
                customer.FirstName.ToLower().Contains(searchString) ||
                customer.LastName.ToLower().Contains(searchString) ||
                customer.Street.ToLower().Contains(searchString) ||
                customer.Zip.ToString().Contains(searchString) ||
                customer.City.ToLower().Contains(searchString) ||
                customer.Country.ToLower().Contains(searchString)
            ).ToList();
            
        }

        public virtual Boolean IsUnique(Customer customer)
        {
            var table = _orderManagementDbContext.Set<Customer>();
            return !table
            .Any(c => (c.FirstName == customer.FirstName) &&
                (c.LastName == customer.LastName));

        }
    }
}
