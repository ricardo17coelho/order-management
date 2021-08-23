using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace order_management.Services
{
    public class CustomerService : ICustomerService
    {
        private readonly RepoCustomer _repository;

        public CustomerService(RepoCustomer repository)
        {
            _repository = repository;
        }
        public Customer Add(Customer entity)
        {
            return _repository.Add(entity);
        }

        public void Delete(Customer entity)
        {
            _repository.Delete(entity);
        }

        public void DeleteById(int id)
        {
            _repository.Delete(id);
        }

        public List<Customer> GetAll()
        {
            return _repository.GetAll().ToList();
        }

        public Customer GetById(int id)
        {
            return _repository.GetById(id);
        }

        public Customer Update(Customer entity)
        {
            return _repository.Update(entity);
        }

        public Boolean IsUnique(Customer entity)
        {
            return _repository.IsUnique(entity);
        }

        public Boolean RequiredFieldsAreNotBlank(Customer entity)
        {
            return entity.FirstName != "" &&
                entity.LastName != "" && 
                entity.Email != "" &&
                entity.CustomerNr != "" &&
                entity.Website != "" &&
                entity.Password != "";
        }

        public Boolean IsValidEmailAddress(string email)
        {
            return Regex.IsMatch(email, @"^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$");
        }

        public Boolean IsValidCustomerNr(string nr)
        {
            return Regex.IsMatch(nr, @"CU([0-9]{5})$");
        }

        public Boolean IsValidWebsite(string website)
        {
            return Regex.IsMatch(website, @"(?:[a-z0-9](?:[a-z0-9-]{0,61}[a-z0-9])?\.)+[a-z0-9][a-z0-9-]{0,61}[a-z0-9]");
        }

        public Boolean IsValidPassword(string password)
        {
            return Regex.IsMatch(password, @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[@$!%*?&])[A-Za-z\d@$!%*?&]{8,}$");
        }

        public List<Customer> Search(string searchString)
        {
            return _repository.Search(searchString);
        }

        public Customer GetByName(string firstName, string lastName)
        {
            return _repository.GetByName(firstName, lastName);
        }
    }
}
