using System;
using System.Collections.Generic;
using System.Text;

namespace order_management.Services
{
    public interface IProductService : IService<Product>
    {
        Boolean IsUnique(Product entity);
        Boolean IsValid(Product entity);
        List<Product> Search(string searchString);
        Product GetByName(string name);
    }
}
