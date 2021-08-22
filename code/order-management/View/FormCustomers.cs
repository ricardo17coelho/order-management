﻿using order_management.Services;
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
        private readonly ICustomerService _customerService;
        private protected ViewCustomers _viewCustomers;
        private protected Customer _customerToEdit;

        public FormCustomers(ICustomerService customerService)
        {
            InitializeComponent();
            _customerService = customerService;
        }

        public void SetCustomerView(ViewCustomers customersView)
        {
            _viewCustomers = customersView;
        }

        public void SetCustomerToEdit(Customer customerToEdit)
        {
            _customerToEdit = customerToEdit;
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

            if(_customerToEdit == null)
            {
                AddNewCustomer(new Customer(firstName, lastName, street, streetNr, zip, city, country));
            }
            else
            {
                _customerToEdit.FirstName = firstName;
                _customerToEdit.LastName = lastName;
                _customerToEdit.Street = street;
                _customerToEdit.StreetNr = streetNr;
                _customerToEdit.Zip = zip;
                _customerToEdit.City = city;
                _customerToEdit.Country = country;
                UpdateCustomer();
            }
        }

        private void CmdCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LoadCustomerToEditIntoFields()
        {
            TxtFirstName.Text = _customerToEdit.FirstName;
            TxtLastName.Text = _customerToEdit.LastName;
            TxtStreet.Text = _customerToEdit.Street;
            TxtStreetNr.Text = _customerToEdit.StreetNr;
            NumZip.Value = _customerToEdit.Zip;
            TxtCity.Text = _customerToEdit.City;
            TxtCountry.Text = _customerToEdit.Country;
        }

        private void AddNewCustomer(Customer customer)
        {
            if (IsValid(customer) && IsUnique(customer))
            {
                _customerService.Add(customer);
                _viewCustomers.ReloadData();
                this.Close();
            }
        }

        private void UpdateCustomer()
        {
            if (IsValid(_customerToEdit))
            {
                _customerService.Update(_customerToEdit);
                _viewCustomers.ReloadData();
                this.Close();
            }
        }

        private Boolean IsUnique(Customer customer)
        {
            if (!_customerService.IsUnique(customer))
            {
                MessageBox.Show("Customer " + customer.FirstName + " " + customer.LastName + " already exists!");
                return false;
            }
            return true;
        }

        private Boolean IsValid(Customer customer)
        {
            if (!_customerService.IsValid(customer))
            {
                MessageBox.Show("First and Lastname is required!");
                return false;
            }
            return true;
        }
    }
}
