using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace order_management
{
    public class RepoProduct : RepoBase<Product>
    {
        public RepoProduct(OrderManagementDbContext orderManagementDbContext) : base(orderManagementDbContext)
        {

        }
        public override IEnumerable<Product> GetAll()
        {
            return _orderManagementDbContext.Products.Include(p => p.ProductCategory).ToList();
        }

        public Product GetByName(string name)
        {
            return _orderManagementDbContext.Products
            .Where(p => p.ProductName == name)
            .FirstOrDefault<Product>();
        }

        public List<Product> Search(string searchString)
        {
            searchString = searchString.ToLower();

            var table = _orderManagementDbContext.Set<Product>();
            return table.Include(p => p.ProductCategory)
            .Where(product =>
                product.ProductName.ToLower().Contains(searchString)
            ).ToList();
        }

        public Boolean IsUnique(Product product)
        {
            var table = _orderManagementDbContext.Set<Product>();
            return !_orderManagementDbContext.Products
                .Any(c => (c.ProductName == product.ProductName));
        }

        public Boolean IsValid(Product product)
        {
            return product.ProductName != "";
        }
    }
}
