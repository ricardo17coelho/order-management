using System;
using System.Collections.Generic;
using System.Text;

namespace order_management
{
    public class ProductCategory
    {
        public int ProductCategoryId { get; set; }
        public string ProductCategoryName { get; set; }
        public virtual ProductCategory Parent { get; set; }
        public virtual int? ParentId { get; set; }

        public ProductCategory(string productCategoryName)
        {
            ProductCategoryName = productCategoryName;
        }

        public ProductCategory(string productCategoryName, ProductCategory parent)
        {
            ProductCategoryName = productCategoryName;
            Parent = parent;
            ParentId = parent.ProductCategoryId;
        }

        public ProductCategory(int id, string productCategoryName)
        {
            ProductCategoryId = id;
            ProductCategoryName = productCategoryName;
        }

        public ProductCategory(int id, string productCategoryName, int parentId)
        {
            ProductCategoryId = id;
            ProductCategoryName = productCategoryName;
            ParentId = parentId;
        }

        public override string ToString()
        {
            return ProductCategoryName;
        }
    }
}
