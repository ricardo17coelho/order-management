using System;
using System.Collections.Generic;
using System.Text;

namespace order_management
{
    public class OrderDetail
    {
        public int OrderDetailId { get; set; }
        
        public int Quantity { get; set; }

        // Navigation Property
        public virtual Order Order { get; set; }
        
        // Navigation Property
        public virtual int OrderId { get; set; }

        // Navigation Property
        public virtual Product Product { get; set; }
        
        // Navigation Property
        public virtual int ProductId { get; set; }

        public OrderDetail(int quantity, Order order, Product product)
        {
            Quantity = quantity;
            Order = order;
            OrderId = order.OrderId;
            Product = product;
            ProductId = product.ProductId;
        }

        public OrderDetail() { }

    }
}
