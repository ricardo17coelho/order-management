using System;
using System.Collections.Generic;
using System.Text;

namespace order_management.Services
{
    public interface ICustomerService : IService<Customer>
    {
        List<Customer> Search(string searchString);
        Boolean IsUnique(Customer entity);
        Boolean RequiredFieldsAreNotBlank(Customer entity);
        Customer GetByName(string firstName, string lastName);
        bool IsValidEmailAddress(string email);
        bool IsValidCustomerNr(string email);
        bool IsValidWebsite(string email);
        bool IsValidPassword(string password);
    }
}
