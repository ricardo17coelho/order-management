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

    public partial class ViewOrders : Form
    {
        private readonly IOrderService _orderService;
        private readonly IBillService _billService;

        public ViewOrders(IOrderService orderService, IBillService billService)
        {
            InitializeComponent();
            _orderService = orderService;
            _billService = billService;
            ReloadData();
        }

        private void CmdAddNew_Click(object sender, EventArgs e)
        {
            var formOrders = (FormOrders)Program.ServiceProvider.GetService(typeof(FormOrders));
            formOrders.SetOrdersView(this);
            formOrders.ShowDialog();
        }

        private void CmdEdit_Click(object sender, EventArgs e)
        {
            var formOrders = (FormOrders)Program.ServiceProvider.GetService(typeof(FormOrders));
            formOrders.SetOrdersView(this);
            Order orderToEdit = (Order)DgvOrders.CurrentRow.DataBoundItem;
            formOrders.SetOrderToEdit(orderToEdit);
            formOrders.ShowDialog();
        }

        private void CmdDelete_Click(object sender, EventArgs e)
        {
            Order orderToDelete = (Order)DgvOrders.CurrentRow.DataBoundItem;
            _orderService.DeleteById(orderToDelete.OrderId);
            ReloadData();
        }

        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {
            DgvOrders.DataSource = _orderService.Search(TxtSearch.Text.ToLower());
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
            DgvOrders.DataSource = _orderService.GetAll();
            DgvOrders.Columns[0].Visible = false;
            DgvOrders.Columns[4].Visible = false;

        }

        private void CmdGenerateBill_Click(object sender, EventArgs e)
        {
            var selectedOrder = (Order)DgvOrders.CurrentRow.DataBoundItem;

            var response = MessageBox.Show($"Generate Bill for {selectedOrder.Customer} ?");

            if (response == DialogResult.OK)
            {
                _billService.GenerateBill(selectedOrder);
                var viewBills = (ViewBills)Program.ServiceProvider.GetService(typeof(ViewBills));
                viewBills.ShowDialog();
            }
        }

        private void CmdViewBills_Click(object sender, EventArgs e)
        {
            var viewBills = (ViewBills)Program.ServiceProvider.GetService(typeof(ViewBills));
            viewBills.ShowDialog();
        }
    }
}
