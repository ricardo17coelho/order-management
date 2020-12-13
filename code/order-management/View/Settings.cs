﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace order_management.View
{
    public partial class Settings : Form
    {
        private Context context;
        public Settings(Context context)
        {
            InitializeComponent();
            this.context = context;
        }

        private void CmdGenerateSampleData_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Generate sample Data for your Database?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                GenerateSampleData();
            }
        }

        private void CmdClearData_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Delete all Data in your Database?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                context.Customers.RemoveRange(context.Customers);
                context.ProductCategories.RemoveRange(context.ProductCategories);
                context.Products.RemoveRange(context.Products);

                context.SaveChanges();
            }
        }

        private void GenerateSampleData()
        {
            GenerateCustomers();
            GenerateProductCategories();
            GenerateProducts();
        }

        private void GenerateProducts()
        {

            List<Product> products = new List<Product>();

            ProductCategory monitors = context.ProductCategories
            .Where(pc => pc.ProductCategoryName == "Monitors")
            .FirstOrDefault<ProductCategory>();

            ProductCategory tablets = context.ProductCategories
            .Where(pc => pc.ProductCategoryName == "Tablets")
            .FirstOrDefault<ProductCategory>();

            products.Add(new Product("HP Compaq 24 Inch", 300, "Fr.", monitors));
            products.Add(new Product("Samsung Tab S7+", 800.95, "Fr.", tablets));
            products.Add(new Product("Ipad 8", 1200.55, "Fr.", tablets));
            products.Add(new Product("Huawai p5", 120.35, "Fr.", tablets));

            foreach (Product product in products)
            {
                if (context.Products.Any(p => p.ProductName == product.ProductName))
                {
                    MessageBox.Show("Product " + product.ProductName + " already exists!");
                }
                else
                {
                    context.Products.Add(product);
                }
            }
            context.SaveChanges();
        }

        private void GenerateProductCategories()
        {
            List<ProductCategory> parentCategories = new List<ProductCategory>();
            parentCategories.Add(new ProductCategory("Computer Equipment"));

            foreach (ProductCategory parentCategory in parentCategories)
            {
                if (context.ProductCategories.Any(pc => pc.ProductCategoryName == parentCategory.ProductCategoryName))
                {
                    MessageBox.Show("Product Category " + parentCategory.ProductCategoryName + " already exists!");
                }
                else
                {
                    context.ProductCategories.Add(parentCategory);
                }
            }
            context.SaveChanges();

            List<ProductCategory> productCategories = new List<ProductCategory>();


            ProductCategory computerEquipment = context.ProductCategories
            .Where(pc => pc.ProductCategoryName == "Computer Equipment")
            .FirstOrDefault<ProductCategory>();

            productCategories.Add(new ProductCategory("Monitors", computerEquipment));
            productCategories.Add(new ProductCategory("Printers", computerEquipment));
            productCategories.Add(new ProductCategory("Tablets"));

            foreach (ProductCategory productCategory in productCategories)
            {
                if (context.ProductCategories.Any(pc => pc.ProductCategoryName == productCategory.ProductCategoryName))
                {
                    MessageBox.Show("Product Category " + productCategory.ProductCategoryName + " already exists!");
                }
                else
                {
                    context.ProductCategories.Add(productCategory);
                }
            }
            context.SaveChanges();

        }

        private void GenerateCustomers()
        {
            List<Customer> customers = new List<Customer>();
            customers.Add(new Customer("Hans", "Müller", "Bahnhofstrasse", "12a", 9400, "Wil", "Schweiz"));
            customers.Add(new Customer("Peter", "Haller", "Dorfstrasse", "5", 8452, "Uznach", "Schweiz"));
            customers.Add(new Customer("Ueli", "Moser", "Lindenstrasse", "27", 4524, "Zuckenriet", "Schweiz"));
            customers.Add(new Customer("Max", "Mustermann", "Bachweg", "1a", 4582, "Schlieren", "Schweiz"));
            customers.Add(new Customer("Vreni", "Kuster", "Hinter dem Baum", "12", 4521, "Walden", "Schweiz"));
            customers.Add(new Customer("Petra", "Schwarz", "Blumenstrasse", "45b", 1234, "Ederswiler", "Schweiz"));

            foreach (Customer customer in customers)
            {
                if (context.Customers.Any(c => (c.FirstName == customer.FirstName) && (c.LastName == customer.LastName)))
                {
                    MessageBox.Show("Customer " + customer.FirstName + " " + customer.LastName + " already exists!");
                }
                else
                {
                    context.Customers.Add(customer);
                }
            }
            context.SaveChanges();


        }
    }
}
