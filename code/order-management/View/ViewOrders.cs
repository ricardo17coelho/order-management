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
        OrderService orderService = new OrderService();

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
            orderService.Delete((Order)DgvOrders.CurrentRow.DataBoundItem);
            ReloadData();
        }

        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {
            DgvOrders.DataSource = orderService.Search(TxtSearch.Text.ToLower());
        }

        private void DgvOrder_SelectionChanged(object sender, EventArgs e)
        {
            if (DgvOrders.SelectedRows != null)
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
            DgvOrders.DataSource = orderService.GetAll();
            DgvOrders.Columns[0].Visible = false;
            DgvOrders.Columns[4].Visible = false;

        }
    }
}
