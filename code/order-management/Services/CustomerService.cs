using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace order_management.Services
{
    public class CustomerService : ICustomerService
    {
        private readonly RepoCustomer _repository;

        public CustomerService(RepoCustomer repository)
        {
            _repository = repository;
        }
        public void Add(Customer entity)
        {
            _repository.Add(entity);
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

        public void Update(Customer entity)
        {
            _repository.Update(entity);
        }

        public Boolean IsUnique(Customer entity)
        {
            return _repository.IsUnique(entity);
        }

        public Boolean IsValid(Customer entity)
        {
            return _repository.IsValid(entity);
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
