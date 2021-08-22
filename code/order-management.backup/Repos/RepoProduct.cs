using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace order_management
{
    public class RepoProduct : RepoBase<Product>
    {
        public new List<Product> GetAll()
        {
            using (var context = new Context())
            {
                return context.Products.Include(p => p.ProductCategory).ToList();
            }
        }

        public Product GetByName(string name)
        {
            using (var context = new Context())
            {
                return context.Products
                .Where(p => p.ProductName == name)
                .FirstOrDefault<Product>();
            }
        }

        public List<Product> Search(string searchString)
        {
            searchString = searchString.ToLower();

            using (var context = new Context())
            {
                var table = context.Set<Product>();
                return table.Include(p => p.ProductCategory)
                .Where(product =>
                    product.ProductName.ToLower().Contains(searchString)
                ).ToList();
            }
        }

        public Boolean IsUnique(Product product)
        {
            using (var context = new Context())
            {
                var table = context.Set<Product>();
                return !context.Products
                    .Any(c => (c.ProductName == product.ProductName));
            }
        }

        public Boolean IsValid(Product product)
        {
            return product.ProductName != "";
        }
    }
}
