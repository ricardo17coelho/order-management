using System;
using System.Collections.Generic;
using System.Text;

namespace order_management
{
    public class ProductCategory
    {
        public int ProductCategoryId { get; set; }
        public string ProductCategoryName { get; set; }
        public ICollection<Product> Products { get; set; }

        public ProductCategory(string productCategoryName)
        {
            ProductCategoryName = productCategoryName;
        }

        public ProductCategory() { }
    }
}
