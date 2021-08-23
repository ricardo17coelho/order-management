using System;
using System.Collections.Generic;
using System.Text;

namespace order_management.Services
{
    public class OrderDetailService : IOrderDetailService
    {
        private readonly RepoOrderDetail _repository;

        public OrderDetailService(RepoOrderDetail repository)
        {
            _repository = repository;
        }
        public OrderDetail Add(OrderDetail entity)
        {
            return _repository.Add(entity);
        }

        public void Delete(OrderDetail entity)
        {
            _repository.Delete(entity);
        }

        public void DeleteById(int id)
        {
            _repository.Delete(id);
        }

        public List<OrderDetail> GetAll()
        {
            return (List<OrderDetail>)_repository.GetAll();
        }

        public OrderDetail GetById(int id)
        {
            return _repository.GetById(id);
        }

        public OrderDetail Update(OrderDetail entity)
        {
            return _repository.Update(entity);
        }

        public Boolean IsValid(OrderDetail entity)
        {
            return _repository.IsValid(entity);
        }

        public List<OrderDetail> GetByOrder(Order order)
        {
            return _repository.GetByOrder(order);
        }
    }
}
