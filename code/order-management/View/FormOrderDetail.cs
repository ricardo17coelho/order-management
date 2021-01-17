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

        OrderDetailService orderDetailService = new OrderDetailService();
        ProductService productService = new ProductService();
        FormOrders formOrders;
        OrderDetail orderDetailToEdit;
        Order order;

        public FormOrderDetail(FormOrders formOrders, Order order)
        {
            InitializeComponent();
            this.formOrders = formOrders;
            this.order = order;
            CbProduct.DataSource = productService.GetAll();
        }

        public FormOrderDetail(FormOrders formOrders, OrderDetail orderDetailToEdit, Order order)
        {
            InitializeComponent();
            this.formOrders = formOrders;
            this.order = order;
            this.orderDetailToEdit = orderDetailToEdit;
            CbProduct.DataSource = productService.GetAll();
            LoadOrderDetailToEditIntoFields();
        }

        private void CmdSave_Click(object sender, EventArgs e)
        {
            int quantity = Convert.ToInt32(NumQuantity.Value);
            Product product = productService.GetByName(CbProduct.Text);

            if (orderDetailToEdit == null)
            {
                AddNewOrderDetail(new OrderDetail(quantity, order, product));
            }
            else
            {
                UpdateOrderDetail(new OrderDetail(quantity, order, product));
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
                orderDetailService.Add(orderDetail);
                formOrders.ReloadData();
                this.Close();
            }
        }

        private void UpdateOrderDetail(OrderDetail orderDetail)
        {
            if (IsValid(orderDetail))
            {
                orderDetailService.Update(orderDetailToEdit, orderDetail);
                formOrders.ReloadData();
                this.Close();
            }
        }

        private Boolean IsValid(OrderDetail orderDetail)
        {
            if (!orderDetailService.IsValid(orderDetail))
            {
                MessageBox.Show("Quantity and Product is required!");
                return false;
            }
            return true;
        }

    }
}
