using System;
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
                CustomerService.RemoveAll(context);
                ProductService.RemoveAll(context);
                ProductCategoryService.RemoveAll(context);
                OrderService.RemoveAll(context);
                OrderDetailService.RemoveAll(context);
                DbService.SaveChanges(context);
            }
        }

        private void GenerateSampleData()
        {
            GenerateCustomers();
            GenerateProductCategories();
            GenerateProducts();
            GenerateOrders();
            GenerateOrderDetails();
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
                if (!ProductService.IsValid(context, product))
                {
                    MessageBox.Show("Productname is required!");
                }
                else if (!ProductService.IsUnique(context, product))
                {
                    MessageBox.Show("Product " + product.ProductName + " already exists!");
                }
                else
                {
                    ProductService.Add(context, product);
                }
            }
        }

        private void GenerateProductCategories()
        {
            List<ProductCategory> parentCategories = new List<ProductCategory>();
            parentCategories.Add(new ProductCategory("Computer Equipment"));

            foreach (ProductCategory parentCategory in parentCategories)
            {
                if (!ProductCategoryService.IsValid(context, parentCategory))
                {
                    MessageBox.Show("Category name is required!");
                }
                else if (!ProductCategoryService.IsUnique(context, parentCategory))
                {
                    MessageBox.Show("Product Category " + parentCategory.ProductCategoryName + " already exists!");
                }
                else
                {
                    ProductCategoryService.Add(context, parentCategory);
                }
            }

            List<ProductCategory> productCategories = new List<ProductCategory>();


            ProductCategory computerEquipment = ProductCategoryService.GetEntityByName(context, "Computer Equipment");

            productCategories.Add(new ProductCategory("Monitors", computerEquipment));
            productCategories.Add(new ProductCategory("Printers", computerEquipment));
            productCategories.Add(new ProductCategory("Tablets"));

            foreach (ProductCategory productCategory in productCategories)
            {
                if (!ProductCategoryService.IsValid(context, productCategory))
                {
                    MessageBox.Show("Category name is required!");
                }
                else if (!ProductCategoryService.IsUnique(context, productCategory))
                {
                    MessageBox.Show("Product Category " + productCategory.ProductCategoryName + " already exists!");
                }
                else
                {
                    ProductCategoryService.Add(context, productCategory);
                }
            }
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
                if (!CustomerService.IsValid(context, customer))
                {
                    MessageBox.Show("First and Lastname is required!");
                }
                else if (!CustomerService.IsUnique(context, customer))
                {
                    MessageBox.Show("Customer " + customer.FirstName + " " + customer.LastName + " already exists!");
                }
                else
                {
                    CustomerService.Add(context, customer);
                }
            }
        }

        private void GenerateOrders()
        {

            Customer hansMueller = CustomerService.GetEntityByName(context, "Hans", "Müller");
            Customer peterHaller = CustomerService.GetEntityByName(context, "Peter", "Haller");

            List<Order> orders = new List<Order>();
            orders.Add(new Order(hansMueller));
            orders.Add(new Order(peterHaller));
            orders.Add(new Order(peterHaller));

            foreach (Order order in orders)
            {
                if (!OrderService.IsValid(context, order))
                {
                    MessageBox.Show("Order is not valid");
                }
                else if (!OrderService.IsUnique(context, order))
                {
                    MessageBox.Show("Order " + order.OrderDate + " " + order.Customer.FirstName + " already exists!");
                }
                else
                {
                    OrderService.Add(context, order);
                }
            }

        }

        private void GenerateOrderDetails()
        {

            Customer hansMueller = CustomerService.GetEntityByName(context, "Hans", "Müller");
            Customer peterHaller = CustomerService.GetEntityByName(context, "Peter", "Haller");

            Order firstOrderFromHansMueller = OrderService.GetOrderByCustomer(context, hansMueller);
            Order firstOrderFromPeterHaller = OrderService.GetOrderByCustomer(context, peterHaller);

            Product ipad8 = ProductService.GetEntityByName(context, "Ipad 8"); 
            Product huawaiP5 = ProductService.GetEntityByName(context, "Huawai p5");

            List<OrderDetail> orderDetails = new List<OrderDetail>();
            orderDetails.Add(new OrderDetail(5, firstOrderFromHansMueller, ipad8));
            orderDetails.Add(new OrderDetail(10, firstOrderFromPeterHaller, huawaiP5));

            foreach (OrderDetail orderDetail in orderDetails)
            {
                if (!OrderDetailService.IsValid(context, orderDetail))
                {
                    MessageBox.Show("OrderDetail is not valid");
                }
                else if (!OrderDetailService.IsUnique(context, orderDetail))
                {
                    MessageBox.Show("Order Detail " + orderDetail.OrderDetailId + " already exists!");
                }
                else
                {
                    OrderDetailService.Add(context, orderDetail);
                }
            }

        }
    }
}
