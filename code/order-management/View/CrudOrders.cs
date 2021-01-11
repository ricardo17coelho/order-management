using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace order_management.View
{
    public partial class CrudOrders : Form
    {
        private Context context;
        private DashBoard dashBoard;

        public CrudOrders(Context context, DashBoard dashBoard)
        {
            this.context = context;
            this.dashBoard = dashBoard;
            InitializeComponent();
        }

        private void CrudOrders_Load(object sender, EventArgs e)
        {
            DataGridViewOrders.DataSource = OrderService.GetBoundedList(context);
            DataGridViewOrderDetails.DataSource = OrderDetailService.GetBoundedList(context);
            CbCustomer.DataSource = CustomerService.GetBoundedList(context);
            CbProductCategory.DataSource = ProductCategoryService.GetBoundedList(context);
        }

        private void CbProductCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            CbProduct.Items.Clear();
            ProductCategory selectedCategory = (ProductCategory)CbProductCategory.SelectedItem;
            List<Product> productsPerCategory = ProductService.GetProductsForCategory(context, selectedCategory);

            foreach(Product product in productsPerCategory)
            {
                CbProduct.Items.Add(product);
            }
        }

        private void CmdOrder_Click(object sender, EventArgs e)
        {
            int quantity = Convert.ToInt32(NumQuantity.Value);

            Customer selectedCustomer = (Customer)CbCustomer.SelectedItem;
            Customer customerFromDb = CustomerService.GetEntityById(context, selectedCustomer.CustomerId);

            Order newOrder = new Order(customerFromDb);
            OrderService.Add(context, newOrder);

            Order orderFromDb = OrderService.GetEntityById(context, newOrder.OrderId);

            Product selectedProduct = (Product)CbProduct.SelectedItem;
            Product productFromDb = ProductService.GetEntityByName(context, selectedProduct.ProductName);

            OrderDetail newOrderDetail = new OrderDetail(quantity, orderFromDb, productFromDb);
            OrderDetailService.Add(context, newOrderDetail);

            dashBoard.UpdateCountLabels();
        }

        private void CmdSave_Click(object sender, EventArgs e)
        {
            DbService.SaveChanges(context);
        }

        private void CmdDelete_Click(object sender, EventArgs e)
        {
            OrderDetail selectedOrderDetail = (OrderDetail)DataGridViewOrderDetails.CurrentRow.DataBoundItem;
            OrderDetailService.Remove(context, selectedOrderDetail);

            dashBoard.UpdateCountLabels();
        }

        private void CmdDeleteOrders_Click(object sender, EventArgs e)
        {
            Order selectedOrder = (Order)DataGridViewOrders.CurrentRow.DataBoundItem;
            OrderService.Remove(context, selectedOrder);

            dashBoard.UpdateCountLabels();

        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }
    }
}
