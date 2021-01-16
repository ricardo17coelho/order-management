using System;
using System.Collections.Generic;
using System.Text;

namespace order_management
{
    public class OrderDetail
    {
        public int OrderDetailId { get; set; }
        public int Quantity { get; set; }
        public virtual Order Order { get; set; }
        public virtual int OrderId { get; set; }
        public virtual Product Product { get; set; }
        public virtual int ProductId { get; set; }

        public OrderDetail(int quantity, Order order, Product product)
        {
            Quantity = quantity;
            Order = order;
            OrderId = order.OrderId;
            Product = product;
            ProductId = product.ProductId;
        }

        // This constructor ist just used in the OnModelCreating() in DBContext
        public OrderDetail(int id, int quantity, int orderId, int productId)
        {
            OrderDetailId = id;
            Quantity = quantity;
            OrderId = orderId;
            ProductId = productId;
        }

        //Add-Migration needs this constructor. No Idea Why :-)
        public OrderDetail() { }

    }
}
