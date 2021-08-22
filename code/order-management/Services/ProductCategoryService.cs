using System;
using System.Collections.Generic;
using System.Text;

namespace order_management.Services
{
    public class ProductCategoryService : IProductCategoryService
    {
        private readonly RepoProductCategory _repository;

        public ProductCategoryService(RepoProductCategory repository)
        {
            _repository = repository;
        }
        public void Add(ProductCategory entity)
        {
            _repository.Add(entity);
        }

        public void Delete(ProductCategory entity)
        {
            _repository.Delete(entity);
        }

        public void DeleteById(int id)
        {
            _repository.Delete(id);
        }

        public List<ProductCategory> GetAll()
        {
            return (List<ProductCategory>)_repository.GetAll();
        }

        public ProductCategory GetById(int id)
        {
            return _repository.GetById(id);
        }

        public void Update(ProductCategory entity)
        {
            _repository.Update(entity);
        }

        public Boolean IsUnique(ProductCategory entity)
        {
            return _repository.IsUnique(entity);
        }

        public Boolean IsValid(ProductCategory entity)
        {
            return _repository.IsValid(entity);
        }

        public List<ProductCategory> GetChildrenByParentId(int categoryId)
        {
            return _repository.GetChildrenByParentId(categoryId);
        }

        public ProductCategory GetByName(string name)
        {
            return _repository.GetByName(name);
        }

        public List<ProductCategory> GetCteDataForTreeView()
        {
            return _repository.GetCteDataForTreeView(); ;
        }

        public List<ProductCategory> Search(string searchString)
        {
            return _repository.Search(searchString);
        }
    }
}
