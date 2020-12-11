using Microsoft.EntityFrameworkCore;
using order_management.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace order_management
{
    public partial class DashBoard : Form
    {
        private Context context;

        public DashBoard(Context context)
        {
            InitializeComponent();
            this.context = context;
        }

        private void CmdCustomers_Click(object sender, EventArgs e)
        {
            CrudCustomers crudCustomers = new CrudCustomers(context);
            crudCustomers.ShowDialog();
        }

        private void CmdProducts_Click(object sender, EventArgs e)
        {
            CrudProducts crudProducts = new CrudProducts(context);
            crudProducts.ShowDialog();
        }

        private void CmdProductCategory_Click(object sender, EventArgs e)
        {
            CrudProductCategory crudProductCategory = new CrudProductCategory(context);
            crudProductCategory.ShowDialog();
        }

        private void CmdGenerateSampleData_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Generate sample Data for your Database?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                GenerateSampleData();
                UpdateCountLabels();
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
                UpdateCountLabels();
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
            List<ProductCategory> productCategories = new List<ProductCategory>();
            productCategories.Add(new ProductCategory("Monitors"));
            productCategories.Add(new ProductCategory("Printers"));
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

        private void DashBoard_Load(object sender, EventArgs e)
        {
            UpdateCountLabels();
        }

        private void UpdateCountLabels()
        {
            //Would be nicer with a Databinding...
            context.Customers.Load();
            context.ProductCategories.Load();
            context.Products.Load();

            lblCustomersCount.Text = context.Customers.Local.ToBindingList().Count + "";
            lblCategoryCount.Text = context.ProductCategories.Local.ToBindingList().Count + "";
            lblProductsCount.Text = context.Products.Local.ToBindingList().Count + "";
        }
    }
}
