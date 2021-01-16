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
        CustomerService customerService = new CustomerService();

        public ViewCustomers()
        {
            InitializeComponent();
            ReloadData();
        }

        private void CmdAddNew_Click(object sender, EventArgs e)
        {
            new FormCustomers(this).ShowDialog();
        }

        private void CmdEdit_Click(object sender, EventArgs e)
        {
            new FormCustomers(this, (Customer)DgvCustomer.CurrentRow.DataBoundItem).ShowDialog();
        }

        private void CmdDelete_Click(object sender, EventArgs e)
        {
            customerService.Delete((Customer)DgvCustomer.CurrentRow.DataBoundItem);
            ReloadData();
        }

        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {
            DgvCustomer.DataSource = customerService.Search(TxtSearch.Text.ToLower());
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
            DgvCustomer.DataSource = customerService.GetAll();
        }
    }
}
