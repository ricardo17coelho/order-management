using System;
using System.Collections.Generic;
using System.Text;

namespace order_management.Services
{
    public class YoyComparisonService : IYoyComparisonService
    {
        private readonly RepoYoyComparison _repository;

        public YoyComparisonService(RepoYoyComparison repository)
        {
            _repository = repository;
        }
        public YoyComparison Add(YoyComparison entity)
        {
            return _repository.Add(entity);
        }

        public void Delete(YoyComparison entity)
        {
            _repository.Delete(entity);
        }

        public void DeleteById(int id)
        {
            _repository.Delete(id);
        }

        public List<YoyComparison> GetAll()
        {
            return (List<YoyComparison>)_repository.GetAll();
        }

        public YoyComparison GetById(int id)
        {
            return _repository.GetById(id);
        }

        public List<YoyComparison> GetYoyComparison()
        {
            return _repository.GetYoyComparison();
        }

        public YoyComparison Update(YoyComparison entity)
        {
            return _repository.Update(entity);
        }
    }
}
