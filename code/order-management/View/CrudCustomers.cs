using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace order_management
{
    public partial class CrudCustomers : Form
    {
        public CrudCustomers()
        {
            InitializeComponent();
        }

        Context dbContext;


        private void CrudCustomers_Load(object sender, EventArgs e)
        {
            dbContext = new Context();
            DataGridViewCustomers.DataSource = dbContext.Customers.Local.ToBindingList();
            dbContext.Customers.Load();
        }

        private void CmdSave_Click(object sender, EventArgs e)
        {
            DataGridViewCustomers.EndEdit();
            dbContext.SaveChanges();
        }

        private void CmdAdd_Click(object sender, EventArgs e)
        {
            string firstName = TxtFirstName.Text;
            string lastName = TxtLastName.Text;
            string street = TxtStreet.Text;

            Customer newCustomer = new Customer(firstName, lastName, street, "5b", 6666, "Saint City", "Italy");
            dbContext.Customers.Add(newCustomer);
            dbContext.SaveChanges();
        }
    }
}
