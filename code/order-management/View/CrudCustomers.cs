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
            //string searchValue = TxtSearch.Text;
            //if (searchValue == "")
            //{
            //    MessageBox.Show("Enter a Value!");
            //}
            //else
            //{
            //    DataGridViewCustomers.ClearSelection();
            //    foreach (DataGridViewRow row in DataGridViewCustomers.Rows)
            //    {
            //        //Cells[1] is Firstname and Cells[2] is Lastname
            //        if (row.Cells[1].Value.ToString().ToLower().StartsWith(searchValue.ToLower()) || 
            //            row.Cells[2].Value.ToString().ToLower().StartsWith(searchValue.ToLower()))
            //        {
            //            row.Selected = true;
            //        }
            //    }
            //}

            //string searchValue = TxtSearch.Text.ToUpper();
            //DataGridViewCustomers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            //try
            //{
            //    bool valueResult = false;
            //    foreach (DataGridViewRow row in DataGridViewCustomers.Rows)
            //    {
            //        for (int i = 0; i < row.Cells.Count; i++)
            //        {
            //            int rowIndex = row.Index;
            //            if (row.Cells[i].Value != null && row.Cells[i].Value.ToString().ToUpper().Equals(searchValue))
            //            {
            //                DataGridViewCustomers.Rows[rowIndex].Selected = true;
            //                valueResult = true;
            //                break;
            //            } else
            //            {
            //                DataGridViewCustomers.Rows[rowIndex].Selected = false;
            //            }
            //        }

            //    }
            //    if (!valueResult)
            //    {
            //        MessageBox.Show("Unable to find " + searchValue, "Not Found");
            //        return;
            //    }
            //}
            //catch (Exception exc)
            //{
            //    MessageBox.Show(exc.Message);
            //}
        }

        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {
            //TODO: remove this line
            //------------------------------------------------------------------------
            DataGridViewCustomers.DataSource = CustomerService.GetBoundedList(context);
            //------------------------------------------------------------------------
            DataTable datatable = GetGridViewDataAsDataTable();
            DataView dv = new DataView(datatable);
            dv.RowFilter = string.Format("Firstname LIKE '%{0}%'", TxtSearch.Text);
            //dv.RowFilter = string.Format("Firstname like '%{0}%' or Lastname like '%{0}%'", textBox1.Text);
            DataGridViewCustomers.DataSource = dv;
        }

        public DataTable GetGridViewDataAsDataTable()
        {
            //Creating DataTable.
            DataTable dt = new DataTable();

            //Adding the Columns.
            foreach (DataGridViewColumn column in DataGridViewCustomers.Columns)
            {
                dt.Columns.Add(column.HeaderText, column.ValueType);
            }

            //Adding the Rows.
            foreach (DataGridViewRow row in DataGridViewCustomers.Rows)
            {
                dt.Rows.Add();
                foreach (DataGridViewCell cell in row.Cells)
                {
                    dt.Rows[dt.Rows.Count - 1][cell.ColumnIndex] = cell.Value.ToString();
                }
            }
            return dt;
        }
    }
}
