using System;
using System.Collections.Generic;
using System.Text;

namespace order_management.Services
{
    public class OrderService : IOrderService
    {
        private readonly RepoOrder _repository;

        public OrderService(RepoOrder repository)
        {
            _repository = repository;
        }
        public void Add(Order entity)
        {
            _repository.Add(entity);
        }

        public void Delete(Order entity)
        {
            _repository.Delete(entity);
        }

        public void DeleteById(int id)
        {
            _repository.Delete(id);
        }

        public List<Order> GetAll()
        {
            return (List<Order>)_repository.GetAll();
        }

        public Order GetById(int id)
        {
            return _repository.GetById(id);
        }

        public void Update(Order entity)
        {
            _repository.Update(entity);
        }

        public Boolean IsUnique(Order entity)
        {
            return _repository.IsUnique(entity);
        }

        public Boolean IsValid(Order entity)
        {
            return _repository.IsValid(entity);
        }

        public List<Order> Search(string searchString)
        {
            return _repository.Search(searchString);
        }
    }
}
