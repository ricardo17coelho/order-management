using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace order_management.View
{
    public partial class FormCustomers : Form
    {

        CustomerService customerService = new CustomerService();
        ViewCustomers viewCustomers;
        Customer customerToEdit;

        public FormCustomers(ViewCustomers customersView)
        {
            InitializeComponent();
            this.viewCustomers = customersView;
        }

        public FormCustomers(ViewCustomers customersView, Customer customerToEdit)
        {
            InitializeComponent();
            this.viewCustomers = customersView;
            this.customerToEdit = customerToEdit;
            LoadCustomerToEditIntoFields();
        }

        private void CmdSave_Click(object sender, EventArgs e)
        {
            string firstName = TxtFirstName.Text;
            string lastName = TxtLastName.Text;
            string street = TxtStreet.Text;
            string streetNr = TxtStreetNr.Text;
            int zip = Convert.ToInt32(NumZip.Value);
            string city = TxtCity.Text;
            string country = TxtCountry.Text;

            if(customerToEdit == null)
            {
                AddNewCustomer(new Customer(firstName, lastName, street, streetNr, zip, city, country));
            }
            else
            {
                UpdateCustomer(new Customer(firstName, lastName, street, streetNr, zip, city, country));
            }
        }

        private void CmdCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LoadCustomerToEditIntoFields()
        {
            TxtFirstName.Text = customerToEdit.FirstName;
            TxtLastName.Text = customerToEdit.LastName;
            TxtStreet.Text = customerToEdit.Street;
            TxtStreetNr.Text = customerToEdit.StreetNr;
            NumZip.Value = customerToEdit.Zip;
            TxtCity.Text = customerToEdit.City;
            TxtCountry.Text = customerToEdit.Country;
        }

        private void AddNewCustomer(Customer customer)
        {
            if (IsValid(customer) && IsUnique(customer))
            {
                customerService.Add(customer);
                viewCustomers.ReloadData();
                this.Close();
            }
        }

        private void UpdateCustomer(Customer customer)
        {
            if (IsValid(customer))
            {
                customerService.Update(customerToEdit, customer);
                viewCustomers.ReloadData();
                this.Close();
            }
        }

        private Boolean IsUnique(Customer customer)
        {
            if (!customerService.IsUnique(customer))
            {
                MessageBox.Show("Customer " + customer.FirstName + " " + customer.LastName + " already exists!");
                return false;
            }
            return true;
        }

        private Boolean IsValid(Customer customer)
        {
            if (!customerService.IsValid(customer))
            {
                MessageBox.Show("First and Lastname is required!");
                return false;
            }
            return true;
        }
    }
}
