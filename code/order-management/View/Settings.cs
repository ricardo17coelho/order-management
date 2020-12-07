using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace order_management.View
{
    public partial class Settings : Form
    {
        private RepositoryManager repositoryManager;

        public Settings(RepositoryManager repositoryManager)
        {
            InitializeComponent();
            this.repositoryManager = repositoryManager;
        }

        private void CmdGenerateSampleData_Click(object sender, EventArgs e)
        {
                List<Customer> customers = new List<Customer>();
                customers.Add(new Customer("Hans", "Müller", "Bahnhofstrasse", "12a", 9400, "Wil", "Schweiz"));
                customers.Add(new Customer("Peter", "Haller", "Dorfstrasse", "5", 8452, "Uznach", "Schweiz"));

                foreach (Customer customer in customers)
                {
                    repositoryManager.CustomerRepository.Add(customer);
                }

                List<Product> products = new List<Product>();
                products.Add(new Product("HP Compaq", 395.95, "Fr.", new ProductCategory("Monitors")));
                products.Add(new Product("HP super laser", 454.55, "Fr.", new ProductCategory("Printers")));

                foreach (Product product in products)
                {
                    repositoryManager.ProductRepository.Add(product);
                }
        }

        private void btnChangeColors_Click(object sender, EventArgs e)
        {
            //string name = "pnlLeft";
            //Control ctn = this.Controls[name];
            //ctn.BackColor = Color.Yellow;
        }
    }
}
