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
    public partial class FormOrderDetail : Form
    {
        private readonly IProductService _productService;
        private readonly IOrderDetailService _orderDetailService;
        private protected FormOrders _formOrders;
        private protected OrderDetail _orderDetailToEdit;
        private protected Order _order;

        public FormOrderDetail(IProductService productService, IOrderDetailService orderDetailService)
        {
            InitializeComponent();
            _productService = productService;
            _orderDetailService = orderDetailService;
            LoadProductData();
        }

        private void LoadProductData()
        {
            CbProduct.DataSource = _productService.GetAll();
        }

        public void SetFormOrders(FormOrders formOrders)
        {
            _formOrders = formOrders;
        }

        public void SetOrder(Order order)
        {
            _order = order;
        }

        public void SetOrderDetailToEdit(OrderDetail orderDetailToEdit)
        {
            _orderDetailToEdit = orderDetailToEdit;
            LoadOrderDetailToEditIntoFields();
        }

        private void CmdSave_Click(object sender, EventArgs e)
        {
            int quantity = Convert.ToInt32(NumQuantity.Value);
            Product product = _productService.GetByName(CbProduct.Text);

            if (_orderDetailToEdit == null)
            {
                AddNewOrderDetail(new OrderDetail(quantity, _order, product));
            }
            else
            {
                _orderDetailToEdit.Quantity = quantity;
                _orderDetailToEdit.Order = _order;
                _orderDetailToEdit.Product = product;
                UpdateOrderDetail();
            }
        }

        private void CmdCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LoadOrderDetailToEditIntoFields()
        {
            NumQuantity.Value = Convert.ToDecimal(_orderDetailToEdit.Quantity);
            CbProduct.Text = _orderDetailToEdit.Product.ToString();
        }

        private void AddNewOrderDetail(OrderDetail orderDetail)
        {
            if (IsValid(orderDetail))
            {
                _orderDetailService.Add(orderDetail);
                _formOrders.ReloadData();
                this.Close();
            }
        }

        private void UpdateOrderDetail()
        {
            if (IsValid(_orderDetailToEdit))
            {
                _orderDetailService.Update(_orderDetailToEdit);
                _formOrders.ReloadData();
                this.Close();
            }
        }

        private Boolean IsValid(OrderDetail orderDetail)
        {
            if (!_orderDetailService.IsValid(orderDetail))
            {
                MessageBox.Show("Quantity and Product is required!");
                return false;
            }
            return true;
        }

    }
}
