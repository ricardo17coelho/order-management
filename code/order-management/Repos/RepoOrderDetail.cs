﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace order_management
{
    public class RepoOrderDetail : RepoBase<OrderDetail>
    {
        public RepoOrderDetail(OrderManagementDbContext orderManagementDbContext) : base(orderManagementDbContext)
        {

        }
        public override IEnumerable<OrderDetail> GetAll()
        {
            return _orderManagementDbContext.OrderDetails.Include(od => od.Order).Include(od => od.Product).ToList();   
        }

        public virtual List<OrderDetail> GetByOrder(Order order)
        {
            return GetAll()
            .Where(o => (o.OrderId == order.OrderId))
            .ToList();
        }

        public virtual List<OrderDetail> Search(string searchString)
        {
            searchString = searchString.ToLower();

            return _orderManagementDbContext.OrderDetails.Include(od => od.Order).Include(od => od.Product)
                .Where(orderDetail =>
                    orderDetail.Product.ProductName.ToLower().Contains(searchString)
                ).ToList();

        }

        public virtual Boolean IsValid(OrderDetail orderDetail)
        {
            return orderDetail.Quantity > 0 &&
              orderDetail.Product != null;
        }
    }
}
