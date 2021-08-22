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
        RepoCustomer repoCustomer = new RepoCustomer();
        RepoOrder repoOrder = new RepoOrder();
        RepoOrderDetail repoOrderDetail = new RepoOrderDetail();
        ViewOrders viewOrders;
        Order orderToEdit;

        public FormOrders(ViewOrders viewOrders)
        {
            InitializeComponent();
            this.viewOrders = viewOrders;
            CbCustomer.DataSource = repoCustomer.GetAll();
        }

        public FormOrders(ViewOrders viewOrders, Order orderToEdit)
        {
            InitializeComponent();
            this.viewOrders = viewOrders;
            this.orderToEdit = orderToEdit;
            CbCustomer.DataSource = repoCustomer.GetAll();
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

            Customer customer = repoCustomer.GetByName(firstName, lastName);
            DateTime date = DtpOrderDate.Value;
            double tax = Convert.ToDouble(NumTax.Value);

            if (orderToEdit == null)
            {
                AddNewOrder(new Order(customer, tax, date));
            }
            else
            {
                orderToEdit.Customer = customer;
                orderToEdit.OrderDate = date;
                orderToEdit.Tax = tax;
                UpdateOrder();
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
                orderToEdit = repoOrder.Add(order);
                viewOrders.ReloadData();
            }
        }

        private void UpdateOrder()
        {
            if (IsValid(orderToEdit))
            {
                repoOrder.Update(orderToEdit);
                viewOrders.ReloadData();
            }
        }

        private Boolean IsUnique(Order order)
        {
            if (!repoOrder.IsUnique(order))
            {
                MessageBox.Show("Order From " + order.Customer.ToString() + " at " + order.OrderDate.ToString() + " already exists!");
                return false;
            }
            return true;
        }

        private Boolean IsValid(Order order)
        {
            if (!repoOrder.IsValid(order))
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
            OrderDetail orderDetailToDelete = (OrderDetail)DgvOrderDetails.CurrentRow.DataBoundItem;
            repoOrderDetail.Delete(orderDetailToDelete.OrderDetailId);
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
            DgvOrderDetails.DataSource = repoOrderDetail.GetByOrder(orderToEdit);
            DgvOrderDetails.Columns[0].Visible = false;
            DgvOrderDetails.Columns[2].Visible = false;
            DgvOrderDetails.Columns[3].Visible = false;
            DgvOrderDetails.Columns[5].Visible = false;
        }
    }
}
