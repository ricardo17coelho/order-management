using System;
using System.Collections.Generic;
using System.Text;

namespace order_management
{
    public class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public double Price { get; set; }
        public string Unit { get; set; }
        public ProductCategory ProductCategory { get; set; }
        public int ProductCategoryId { get; set; }


        public Product(string productName, double price, string unit, ProductCategory productCategory)
        {
            ProductName = productName;
            Price = price;
            Unit = unit;
            ProductCategory = productCategory;
            ProductCategoryId = productCategory.ProductCategoryId;
        }

        public Product() { }
    }
}
