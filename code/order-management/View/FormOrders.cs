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
        CustomerService customerService = new CustomerService();
        OrderService orderService = new OrderService();
        OrderDetailService orderDetailService = new OrderDetailService();
        ViewOrders viewOrders;
        Order orderToEdit;

        public FormOrders(ViewOrders viewOrders)
        {
            InitializeComponent();
            this.viewOrders = viewOrders;
            CbCustomer.DataSource = customerService.GetAll();
        }

        public FormOrders(ViewOrders viewOrders, Order orderToEdit)
        {
            InitializeComponent();
            this.viewOrders = viewOrders;
            this.orderToEdit = orderToEdit;
            CbCustomer.DataSource = customerService.GetAll();
            LoadOrderToEditIntoFields();
            ReloadData();
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

            Customer customer = customerService.GetByName(firstName, lastName);
            DateTime date = DtpOrderDate.Value;
            double tax = Convert.ToDouble(NumTax.Value);

            if (orderToEdit == null)
            {
                AddNewOrder(new Order(customer, tax, date));
            }
            else
            {
                UpdateOrder(new Order(customer, tax, date));
            }
        }

        private void CmdCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LoadOrderToEditIntoFields()
        {
            CbCustomer.Text = orderToEdit.Customer.ToString();
            DtpOrderDate.Value = orderToEdit.OrderDate;
            NumTax.Value = Convert.ToDecimal(orderToEdit.Tax);
        }

        private void AddNewOrder(Order order)
        {
            if (IsValid(order) && IsUnique(order))
            {
                orderToEdit = orderService.Add(order);
                viewOrders.ReloadData();
            }
        }

        private void UpdateOrder(Order order)
        {
            if (IsValid(order))
            {
                orderService.Update(orderToEdit, order);
                viewOrders.ReloadData();
            }
        }

        private Boolean IsUnique(Order order)
        {
            if (!orderService.IsUnique(order))
            {
                MessageBox.Show("Order From " + order.Customer.ToString() + " at " + order.OrderDate.ToString() + " already exists!");
                return false;
            }
            return true;
        }

        private Boolean IsValid(Order order)
        {
            if (!orderService.IsValid(order))
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
            new FormOrderDetail(this, orderToEdit).ShowDialog();
        }

        private void CmdEdit_Click(object sender, EventArgs e)
        {
            new FormOrderDetail(this, (OrderDetail)DgvOrderDetails.CurrentRow.DataBoundItem, orderToEdit).ShowDialog();
        }

        private void CmdDelete_Click(object sender, EventArgs e)
        {
            orderDetailService.Delete((OrderDetail)DgvOrderDetails.CurrentRow.DataBoundItem);
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
            DgvOrderDetails.DataSource = orderDetailService.GetByOrder(orderToEdit);
            DgvOrderDetails.Columns[0].Visible = false;
            DgvOrderDetails.Columns[2].Visible = false;
            DgvOrderDetails.Columns[3].Visible = false;
            DgvOrderDetails.Columns[5].Visible = false;
        }
    }
}
