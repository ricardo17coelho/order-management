using System;
using System.Collections.Generic;
using System.Text;

namespace order_management.Services
{
    public interface ICustomerService : IService<Customer>
    {
        List<Customer> Search(string searchString);
        Boolean IsUnique(Customer entity);
        Boolean IsValid(Customer entity);
        Customer GetByName(string firstName, string lastName);
    }
}
