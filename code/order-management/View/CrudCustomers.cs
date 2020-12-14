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
            DataGridViewCustomers.DataSource = CustomerService.GetBoundedList(context);
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

            if (!CustomerService.IsValid(context, newCustomer))
            {
                MessageBox.Show("First and Lastname is required!");
            }
            else if (!CustomerService.IsUnique(context, newCustomer))
            {
                MessageBox.Show("Customer " + newCustomer.FirstName + " " + newCustomer.LastName + " already exists!");
            }
            else
            {
                CustomerService.Add(context, newCustomer);
            }
        }

        private void CmdDelete_Click(object sender, EventArgs e)
        {
            Customer selectedCustomer = (Customer)DataGridViewCustomers.CurrentRow.DataBoundItem;
            CustomerService.Remove(context, selectedCustomer);
        }

        private void CmdSave_Click(object sender, EventArgs e)
        {
            CustomerService.SaveChanges(context);
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
                    if (row.Cells[1].Value.ToString().ToLower().StartsWith(searchValue.ToLower()) || 
                        row.Cells[2].Value.ToString().ToLower().StartsWith(searchValue.ToLower()))
                    {
                        row.Selected = true;
                    }
                }
            }
        }
    }
}
