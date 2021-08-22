using order_management.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace order_management.View
{
    public partial class ViewCustomers : Form
    {
        private readonly ICustomerService _customerService;

        public ViewCustomers(ICustomerService customerService)
        {
            InitializeComponent();
            _customerService = customerService;
            ReloadData();
        }

        private void CmdAddNew_Click(object sender, EventArgs e)
        {
            var formCustomers = (FormCustomers)Program.ServiceProvider.GetService(typeof(FormCustomers));
            formCustomers.SetCustomerView(this);
            formCustomers.ShowDialog();
        }

        private void CmdEdit_Click(object sender, EventArgs e)
        {
            var formCustomers = (FormCustomers)Program.ServiceProvider.GetService(typeof(FormCustomers));
            formCustomers.SetCustomerView(this);
            Customer customerToEdit = (Customer)DgvCustomer.CurrentRow.DataBoundItem;
            formCustomers.SetCustomerToEdit(customerToEdit);
            formCustomers.ShowDialog();
        }

        private void CmdDelete_Click(object sender, EventArgs e)
        {
            Customer customerToDelete = (Customer)DgvCustomer.CurrentRow.DataBoundItem;
            _customerService.DeleteById(customerToDelete.CustomerId);
            ReloadData();
        }

        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {
            DgvCustomer.DataSource = _customerService.Search(TxtSearch.Text.ToLower());
        }

        private void DgvCustomer_SelectionChanged(object sender, EventArgs e)
        {
            if (DgvCustomer.SelectedRows != null)
            {
                CmdEdit.Enabled = true;
                CmdDelete.Enabled = true;
            }
            else
            {
                CmdEdit.Enabled = false;
                CmdDelete.Enabled = false;
            }
        }

        public void ReloadData()
        {
            DgvCustomer.DataSource = _customerService.GetAll();
            DgvCustomer.Columns[0].Visible = false;
        }

        private void TxtSearch_Enter(object sender, EventArgs e)
        {
            lblParams.Visible = true;
        }

        private void TxtSearch_Leave(object sender, EventArgs e)
        {
            lblParams.Visible = false;
        }
    }
}
