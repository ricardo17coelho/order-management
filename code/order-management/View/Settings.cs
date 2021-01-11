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
            customers.Add(new Customer("Andreas", "Rot", "Bahnhofplatz", "13", 9452, "Spreitebach", "Schweiz"));
            customers.Add(new Customer("Jürgen", "Blyatman", "Huebstrasse", "16", 9152, "Mörschwil", "Schweiz"));
            customers.Add(new Customer("Oskar", "Kanban", "Rosenweg", "1b", 8523, "Interlaken", "Schweiz"));
            customers.Add(new Customer("Karin", "Blattsalat", "Bachfeldstrasse", "5", 5423, "Flieren", "Schweiz"));

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
            Customer vreniKuster = CustomerService.GetEntityByName(context, "Vreni", "Kuster");
            Customer petraSchwarz = CustomerService.GetEntityByName(context, "Petra", "Schwarz");
            Customer maxMustermann = CustomerService.GetEntityByName(context, "Max", "Mustermann");
            Customer andreasRot = CustomerService.GetEntityByName(context, "Andreas", "Rot");
            Customer jürgenBlyatman = CustomerService.GetEntityByName(context, "Jürgen", "Blyatman");
            Customer oskarKanban = CustomerService.GetEntityByName(context, "Oskar", "Kanban");
            Customer karinBlattsalat = CustomerService.GetEntityByName(context, "Karin", "Blattsalat");

            List<Order> orders = new List<Order>();
            orders.Add(new Order(vreniKuster, new DateTime(2018, 8, 15)));
            orders.Add(new Order(maxMustermann, new DateTime(2018, 8, 15)));
            orders.Add(new Order(andreasRot, new DateTime(2018, 8, 15)));
            orders.Add(new Order(jürgenBlyatman, new DateTime(2019, 8, 15)));
            orders.Add(new Order(oskarKanban, new DateTime(2019, 11, 15)));

            orders.Add(new Order(karinBlattsalat, new DateTime(2020, 3, 15)));
            orders.Add(new Order(karinBlattsalat, new DateTime(2020, 6, 15)));
            orders.Add(new Order(hansMueller, new DateTime(2018, 1, 15)));
            orders.Add(new Order(hansMueller, new DateTime(2020, 7, 15)));
            orders.Add(new Order(hansMueller));
            orders.Add(new Order(petraSchwarz, new DateTime(2020, 11, 15)));
            orders.Add(new Order(petraSchwarz, new DateTime(2018, 12, 15)));
            orders.Add(new Order(peterHaller));
            orders.Add(new Order(peterHaller, new DateTime(2018, 4, 15)));


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
            Customer vreniKuster = CustomerService.GetEntityByName(context, "Vreni", "Kuster");
            Customer petraSchwarz = CustomerService.GetEntityByName(context, "Petra", "Schwarz");
            Customer maxMustermann = CustomerService.GetEntityByName(context, "Max", "Mustermann");
            Customer andreasRot = CustomerService.GetEntityByName(context, "Andreas", "Rot");
            Customer jürgenBlyatman = CustomerService.GetEntityByName(context, "Jürgen", "Blyatman");
            Customer oskarKanban = CustomerService.GetEntityByName(context, "Oskar", "Kanban");
            Customer karinBlattsalat = CustomerService.GetEntityByName(context, "Karin", "Blattsalat");

            Order firstOrderFromHansMueller = OrderService.GetOrdersByCustomer(context, hansMueller)[0];
            Order firstOrderFromPeterHaller = OrderService.GetOrdersByCustomer(context, peterHaller)[0];
            Order firstOrderFromVreniKuster = OrderService.GetOrdersByCustomer(context, vreniKuster)[0];
            Order firstOrderFromPetraSchwarz = OrderService.GetOrdersByCustomer(context, petraSchwarz)[0];
            Order firstOrderFromMaxMustermann = OrderService.GetOrdersByCustomer(context, maxMustermann)[0];
            Order firstOrderFromAndreasRot = OrderService.GetOrdersByCustomer(context, andreasRot)[0];
            Order firstOrderFromJürgenBlyatman = OrderService.GetOrdersByCustomer(context, jürgenBlyatman)[0];
            Order firstOrderFromOskarKanban = OrderService.GetOrdersByCustomer(context, oskarKanban)[0];
            Order firstOrderFromKarinBlattsalat = OrderService.GetOrdersByCustomer(context, karinBlattsalat)[0];
            Order secondOrderFromKarinBlattsalat = OrderService.GetOrdersByCustomer(context, karinBlattsalat)[1];

            Product ipad8 = ProductService.GetEntityByName(context, "Ipad 8");
            Product huawaiP5 = ProductService.GetEntityByName(context, "Huawai p5");
            Product samsungTabS7 = ProductService.GetEntityByName(context, "Samsung Tab S7+");
            Product hPCompaq24Inch = ProductService.GetEntityByName(context, "HP Compaq 24 Inch");

            List<OrderDetail> orderDetails = new List<OrderDetail>();
            orderDetails.Add(new OrderDetail(5, firstOrderFromHansMueller, ipad8));
            orderDetails.Add(new OrderDetail(10, firstOrderFromPeterHaller, huawaiP5));
            orderDetails.Add(new OrderDetail(10, firstOrderFromVreniKuster, samsungTabS7));
            orderDetails.Add(new OrderDetail(1, firstOrderFromPetraSchwarz, ipad8));
            orderDetails.Add(new OrderDetail(1, firstOrderFromMaxMustermann, hPCompaq24Inch));
            orderDetails.Add(new OrderDetail(2, firstOrderFromAndreasRot, hPCompaq24Inch));
            orderDetails.Add(new OrderDetail(2, firstOrderFromJürgenBlyatman, huawaiP5));
            orderDetails.Add(new OrderDetail(2, firstOrderFromOskarKanban, ipad8));
            orderDetails.Add(new OrderDetail(3, firstOrderFromKarinBlattsalat, samsungTabS7));
            orderDetails.Add(new OrderDetail(3, secondOrderFromKarinBlattsalat, ipad8));

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
