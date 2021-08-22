using System;
using System.Collections.Generic;
using System.Text;

namespace order_management.Services
{
    public class ProductService : IProductService
    {
        private readonly RepoProduct _repository;

        public ProductService(RepoProduct repository)
        {
            _repository = repository;
        }
        public void Add(Product entity)
        {
            _repository.Add(entity);
        }

        public void Delete(Product entity)
        {
            _repository.Delete(entity);
        }

        public void DeleteById(int id)
        {
            _repository.Delete(id);
        }

        public List<Product> GetAll()
        {
            return (List<Product>)_repository.GetAll();
        }

        public Product GetById(int id)
        {
            return _repository.GetById(id);
        }

        public void Update(Product entity)
        {
            _repository.Update(entity);
        }

        public Boolean IsUnique(Product entity)
        {
            return _repository.IsUnique(entity);
        }

        public Boolean IsValid(Product entity)
        {
            return _repository.IsValid(entity);
        }

        public List<Product> Search(string searchString)
        {
            return _repository.Search(searchString);
        }

        public Product GetByName(string name)
        {
            return _repository.GetByName(name);
        }

    }
}
