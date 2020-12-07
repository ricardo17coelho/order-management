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
        private RepositoryManager repositoryManager;

        public CrudCustomers(RepositoryManager repositoryManager)
        {
            InitializeComponent();
            this.repositoryManager = repositoryManager;
        }

        private void CrudCustomers_Load(object sender, EventArgs e)
        {
            DataGridViewCustomers.DataSource = repositoryManager.CustomerRepository.GetBoundedList();
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
            repositoryManager.CustomerRepository.Add(newCustomer);
        }

        private void CmdDelete_Click(object sender, EventArgs e)
        {
            //get selected customer
            //customerRepository.Remove(selected customer);
        }

        private void CmdSave_Click(object sender, EventArgs e)
        {
            repositoryManager.CustomerRepository.Save();
        }
    }
}
