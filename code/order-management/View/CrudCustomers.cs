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
        private Context context;

        public CrudCustomers(Context context)
        {
            InitializeComponent();
            this.context = context;
        }

        private void CrudCustomers_Load(object sender, EventArgs e)
        {
            context.Customers.Load();
            DataGridViewCustomers.DataSource = context.Customers.Local.ToBindingList();
            DataGridViewCustomers.ClearSelection();
        }

        private void CmdAdd_Click(object sender, EventArgs e)
        {
            string firstName = TxtFirstName.Text;
            string lastName = TxtLastName.Text;
            string street = TxtStreet.Text;
            string streetNr = TxtStreetNr.Text;
            int zip = Convert.ToInt32(NumZip.Value);
            string city = TxtCity.Text;
            string country = TxtCountry.Text;

            Customer newCustomer = new Customer(firstName, lastName, street, streetNr, zip, city, country);
            context.Customers.Add(newCustomer);
            context.SaveChanges();
        }

        private void CmdDelete_Click(object sender, EventArgs e)
        {
            Customer selectedCustomer = (Customer)DataGridViewCustomers.CurrentRow.DataBoundItem;
            context.Remove(selectedCustomer);
            context.SaveChanges();

        }

        private void CmdSave_Click(object sender, EventArgs e)
        {
            context.SaveChanges();
        }

        private void CmdSearch_Click(object sender, EventArgs e)
        {
            string searchValue = TxtSearch.Text;
            if (searchValue == "")
            {
                MessageBox.Show("Enter a Value!");
            }
            else
            {
                DataGridViewCustomers.ClearSelection();
                foreach (DataGridViewRow row in DataGridViewCustomers.Rows)
                {
                    //Cells[1] is Firstname and Cells[2] is Lastname
                    if (row.Cells[1].Value.ToString().ToLower().StartsWith(searchValue.ToLower()) || row.Cells[2].Value.ToString().ToLower().StartsWith(searchValue.ToLower()))
                    {
                        row.Selected = true;
                    }
                }
            }

        }
    }
}
