using System;
using System.Collections.Generic;
using System.Text;

namespace order_management.Services
{
    public class BillService : IBillService
    {
        private readonly RepoBill _repository;

        public BillService(RepoBill repository)
        {
            _repository = repository;
        }
        public void Add(Bill entity)
        {
            _repository.Add(entity);
        }

        public void Delete(Bill entity)
        {
            _repository.Delete(entity);
        }

        public void DeleteById(int id)
        {
            _repository.Delete(id);
        }

        public List<Bill> GetAll()
        {
            return (List<Bill>)_repository.GetAll();
        }

        public List<Bill> Search(string searchString)
        {
            return _repository.Search(searchString);
        }

        public Bill GetById(int id)
        {
            return _repository.GetById(id);
        }

        public void Update(Bill entity)
        {
            _repository.Update(entity);
        }

        public Bill GenerateBill(Order order)
        {
            return _repository.GenerateBill(order);
        }
    }
}
