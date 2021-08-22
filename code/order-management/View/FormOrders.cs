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
    public partial class FormOrders : Form
    {
        private readonly ICustomerService _customerService;
        private readonly IOrderService _orderService;
        private readonly IOrderDetailService _orderDetailService;
        private protected ViewOrders _viewOrders;
        private protected Order _orderToEdit;

        public FormOrders(ICustomerService customerService, IOrderService orderService, IOrderDetailService orderDetailService)
        {
            InitializeComponent();
            _customerService = customerService;
            _orderService = orderService;
            _orderDetailService = orderDetailService;
            LoadAllCustomersData();
        }

        private void LoadAllCustomersData()
        {
            CbCustomer.DataSource = _customerService.GetAll();
        }

        public void SetOrdersView(ViewOrders viewOrders)
        {
            _viewOrders = viewOrders;
        }

        public void SetOrderToEdit(Order orderToEdit)
        {
            _orderToEdit = orderToEdit;
            LoadOrderToEditIntoFields();
        }

        private void CmdSave_Click(object sender, EventArgs e)
        {
            SaveOrder();
            this.Close();
        }

        private void SaveOrder()
        {
            string firstName = CbCustomer.Text.Split(" ")[0]; //Risky for Names with Space!
            string lastName = CbCustomer.Text.Split(" ")[1]; //Risky for Names with Space!

            Customer customer = _customerService.GetByName(firstName, lastName);
            DateTime date = DtpOrderDate.Value;
            double tax = Convert.ToDouble(NumTax.Value);

            if (_orderToEdit == null)
            {
                AddNewOrder(new Order(customer, tax, date));
            }
            else
            {
                _orderToEdit.Customer = customer;
                _orderToEdit.OrderDate = date;
                _orderToEdit.Tax = tax;
                UpdateOrder();
            }
        }

        private void CmdCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LoadOrderToEditIntoFields()
        {
            CbCustomer.Text = _orderToEdit.Customer.ToString();
            DtpOrderDate.Value = _orderToEdit.OrderDate;
            NumTax.Value = Convert.ToDecimal(_orderToEdit.Tax);
        }

        private void AddNewOrder(Order order)
        {
            if (IsValid(order) && IsUnique(order))
            {
                _orderService.Add(order);
                _viewOrders.ReloadData();
            }
        }

        private void UpdateOrder()
        {
            if (IsValid(_orderToEdit))
            {
                _orderService.Update(_orderToEdit);
                _viewOrders.ReloadData();
            }
        }

        private Boolean IsUnique(Order order)
        {
            if (!_orderService.IsUnique(order))
            {
                MessageBox.Show("Order From " + order.Customer.ToString() + " at " + order.OrderDate.ToString() + " already exists!");
                return false;
            }
            return true;
        }

        private Boolean IsValid(Order order)
        {
            if (!_orderService.IsValid(order))
            {
                MessageBox.Show("Customer and Date is required!");
                return false;
            }
            return true;
        }

        private void CmdAddNew_Click(object sender, EventArgs e)
        {
            // It could be a new order.
            // This must be saved before we can add some details
            SaveOrder();
            var formOrderDetail = (FormOrderDetail)Program.ServiceProvider.GetService(typeof(FormOrderDetail));
            formOrderDetail.SetFormOrders(this);
            formOrderDetail.SetOrder(_orderToEdit);
            formOrderDetail.ShowDialog();
        }

        private void CmdEdit_Click(object sender, EventArgs e)
        {
            var formOrderDetail = (FormOrderDetail)Program.ServiceProvider.GetService(typeof(FormOrderDetail));
            formOrderDetail.SetFormOrders(this);
            OrderDetail orderDetailToEdit = (OrderDetail)DgvOrderDetails.CurrentRow.DataBoundItem;
            formOrderDetail.SetOrderDetailToEdit(orderDetailToEdit);
            formOrderDetail.SetOrder(_orderToEdit);
            formOrderDetail.ShowDialog();
        }

        private void CmdDelete_Click(object sender, EventArgs e)
        {
            OrderDetail orderDetailToDelete = (OrderDetail)DgvOrderDetails.CurrentRow.DataBoundItem;
            _orderDetailService.DeleteById(orderDetailToDelete.OrderDetailId);
            ReloadData();
        }

        private void DgvOrderDetails_SelectionChanged(object sender, EventArgs e)
        {
            if (DgvOrderDetails.SelectedRows != null)
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
            DgvOrderDetails.DataSource = _orderDetailService.GetByOrder(_orderToEdit);
            DgvOrderDetails.Columns[0].Visible = false;
            DgvOrderDetails.Columns[2].Visible = false;
            DgvOrderDetails.Columns[3].Visible = false;
            DgvOrderDetails.Columns[5].Visible = false;
        }
    }
}
