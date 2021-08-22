using System;
using System.Collections.Generic;
using System.Text;

namespace order_management.Services
{
    public interface IProductCategoryService : IService<ProductCategory>
    {
        Boolean IsUnique(ProductCategory entity);
        Boolean IsValid(ProductCategory entity);
        List<ProductCategory> GetChildrenByParentId(int categoryId);
        ProductCategory GetByName(string name);
        List<ProductCategory> GetCteDataForTreeView();
        List<ProductCategory> Search(string searchString);
    }
}
