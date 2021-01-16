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
        OrderDetailService orderDetailService = new OrderDetailService();

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
            //new FormOrders(this, (OrderDetail)DgvOrders.CurrentRow.DataBoundItem).ShowDialog();
        }

        private void CmdDelete_Click(object sender, EventArgs e)
        {
            orderDetailService.Delete((OrderDetail)DgvOrders.CurrentRow.DataBoundItem);
            ReloadData();
        }

        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {
            DgvOrders.DataSource = orderDetailService.Search(TxtSearch.Text.ToLower());
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
            DgvOrders.DataSource = orderDetailService.GetAll();
        }
    }
}
