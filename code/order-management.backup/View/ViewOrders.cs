using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace order_management.View
{

    public partial class ViewOrders : Form
    {
        RepoOrder repoOrder = new RepoOrder();
        RepoBill repoBill = new RepoBill();

        public ViewOrders()
        {
            InitializeComponent();
            ReloadData();
        }

        private void CmdAddNew_Click(object sender, EventArgs e)
        {
            new FormOrders(this).ShowDialog();
        }

        private void CmdEdit_Click(object sender, EventArgs e)
        {
            new FormOrders(this, (Order)DgvOrders.CurrentRow.DataBoundItem).ShowDialog();
        }

        private void CmdDelete_Click(object sender, EventArgs e)
        {
            Order orderToDelete = (Order)DgvOrders.CurrentRow.DataBoundItem;
            repoOrder.Delete(orderToDelete.OrderId);
            ReloadData();
        }

        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {
            DgvOrders.DataSource = repoOrder.Search(TxtSearch.Text.ToLower());
        }

        private void DgvOrder_SelectionChanged(object sender, EventArgs e)
        {
            if (DgvOrders.SelectedRows != null)
            {
                CmdEdit.Enabled = true;
                CmdDelete.Enabled = true;
                CmdGenerateBill.Enabled = true;
            }
            else
            {
                CmdEdit.Enabled = false;
                CmdDelete.Enabled = false;
                CmdGenerateBill.Enabled = false;
            }
        }

        public void ReloadData()
        {
            DgvOrders.DataSource = repoOrder.GetAll();
            DgvOrders.Columns[0].Visible = false;
            DgvOrders.Columns[4].Visible = false;

        }

        private void CmdGenerateBill_Click(object sender, EventArgs e)
        {
            var selectedOrder = (Order)DgvOrders.CurrentRow.DataBoundItem;

            var response = MessageBox.Show($"Generate Bill for {selectedOrder.Customer} ?");

            if (response == DialogResult.OK)
            {
                repoBill.GenerateBill(selectedOrder);
                new ViewBills().ShowDialog();
            }
        }

        private void CmdViewBills_Click(object sender, EventArgs e)
        {
            new ViewBills().ShowDialog();
        }
    }
}
