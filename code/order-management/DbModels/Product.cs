﻿using System;
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

        // Navigation Property
        public virtual ProductCategory ProductCategory { get; set; }

        // Navigation Property
        public virtual int ProductCategoryId { get; set; }

        public Product(string productName, double price, string unit, ProductCategory productCategory)
        {
            ProductName = productName;
            Price = price;
            Unit = unit;
            ProductCategory = productCategory;
            ProductCategoryId = productCategory.ProductCategoryId;
            this.Date = DateTime.Now;
        }

        public Product(string productName, double price, string unit, DateTime date, ProductCategory productCategory)
        {
            ProductName = productName;
            Price = price;
            Unit = unit;
            this.Date = date;
            ProductCategory = productCategory;
            ProductCategoryId = productCategory.ProductCategoryId;
        }

        public Product() { }

        public override string ToString()
        {
            return ProductName;
        }
    }
}
