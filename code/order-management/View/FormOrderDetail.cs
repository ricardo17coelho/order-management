using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace order_management.View
{
    public partial class FormOrderDetail : Form
    {

        RepoOrderDetail repoOrderDetail = new RepoOrderDetail();
        RepoProduct repoProduct = new RepoProduct();
        FormOrders formOrders;
        OrderDetail orderDetailToEdit;
        Order order;

        public FormOrderDetail(FormOrders formOrders, Order order)
        {
            InitializeComponent();
            this.formOrders = formOrders;
            this.order = order;
            CbProduct.DataSource = repoProduct.GetAll();
        }

        public FormOrderDetail(FormOrders formOrders, OrderDetail orderDetailToEdit, Order order)
        {
            InitializeComponent();
            this.formOrders = formOrders;
            this.order = order;
            this.orderDetailToEdit = orderDetailToEdit;
            CbProduct.DataSource = repoProduct.GetAll();
            LoadOrderDetailToEditIntoFields();
        }

        private void CmdSave_Click(object sender, EventArgs e)
        {
            int quantity = Convert.ToInt32(NumQuantity.Value);
            Product product = repoProduct.GetByName(CbProduct.Text);

            if (orderDetailToEdit == null)
            {
                AddNewOrderDetail(new OrderDetail(quantity, order, product));
            }
            else
            {
                orderDetailToEdit.Quantity = quantity;
                orderDetailToEdit.Order = order;
                orderDetailToEdit.Product = product;
                UpdateOrderDetail();
            }
        }

        private void CmdCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LoadOrderDetailToEditIntoFields()
        {
            NumQuantity.Value = Convert.ToDecimal(orderDetailToEdit.Quantity);
            CbProduct.Text = orderDetailToEdit.Product.ToString();
        }

        private void AddNewOrderDetail(OrderDetail orderDetail)
        {
            if (IsValid(orderDetail))
            {
                repoOrderDetail.Add(orderDetail);
                formOrders.ReloadData();
                this.Close();
            }
        }

        private void UpdateOrderDetail()
        {
            if (IsValid(orderDetailToEdit))
            {
                repoOrderDetail.Update(orderDetailToEdit);
                formOrders.ReloadData();
                this.Close();
            }
        }

        private Boolean IsValid(OrderDetail orderDetail)
        {
            if (!repoOrderDetail.IsValid(orderDetail))
            {
                MessageBox.Show("Quantity and Product is required!");
                return false;
            }
            return true;
        }

    }
}
