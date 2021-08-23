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
        public DateTime Date { get; set; }
        public virtual ProductCategory ProductCategory { get; set; }
        public virtual int ProductCategoryId { get; set; }

        public Product(string productName, double price, string unit, DateTime date, ProductCategory productCategory)
        {
            ProductName = productName;
            Price = price;
            Unit = unit;
            Date = date;
            ProductCategory = productCategory;
            ProductCategoryId = productCategory.ProductCategoryId;
        }

        public Product(int id, string productName, double price, string unit, DateTime date, int productCategoryId)
        {
            ProductId = id;
            ProductName = productName;
            Price = price;
            Unit = unit;
            ProductCategoryId = productCategoryId;
            Date = date;
        }

        public Product() { }

        public override string ToString()
        {
            return ProductName;
        }
    }
}
