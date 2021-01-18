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

        // Constructor for creating a new Root Category
        public ProductCategory(string productCategoryName)
        {
            ProductCategoryName = productCategoryName;
        }

        // Constructor for creating a new Category with a Parent Category
        public ProductCategory(string productCategoryName, ProductCategory parent)
        {
            ProductCategoryName = productCategoryName;
            Parent = parent;
            ParentId = parent.ProductCategoryId;
        }

        // This constructor ist just used in the OnModelCreating() in DBContext
        public ProductCategory(int id, string productCategoryName)
        {
            ProductCategoryId = id;
            ProductCategoryName = productCategoryName;
        }

        // This constructor ist just used in the OnModelCreating() in DBContext
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
