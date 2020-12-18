using System;
using System.Collections.Generic;
using System.Text;

namespace order_management
{
    public class ProductCategory
    {
        public int ProductCategoryId { get; set; }
        
        public string ProductCategoryName { get; set; }
        
        // Recursive Navigation Property
        public virtual ProductCategory Parent { get; set; }

        // Recursive Navigation Property
        public virtual int? ParentId { get; set; }

        public ProductCategory(string productCategoryName, ProductCategory parentCategory)
        {
            ProductCategoryName = productCategoryName;
            Parent = parentCategory;
            ParentId = parentCategory.ProductCategoryId;
        }

        public ProductCategory(string productCategoryName)
        {
            ProductCategoryName = productCategoryName;
        }

        public ProductCategory() { }

        public override string ToString()
        {
            return ProductCategoryName;
        }
    }
}
