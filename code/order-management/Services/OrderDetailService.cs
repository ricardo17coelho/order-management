using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace order_management
{
    public class OrderDetailService
    {

        public List<OrderDetail> GetAll()
        {
            using (var context = new Context())
            {
                return context.OrderDetails.Include(od => od.Order).Include(od => od.Product).ToList();
            }
        }

        public List<OrderDetail> GetByOrder(Order order)
        {
            using (var context = new Context())
            {
                return GetAll()
                .Where(o => (o.OrderId == order.OrderId))
                .ToList();
            }
        }

        public OrderDetail GetById(int id)
        {
            using (var context = new Context())
            {
                return context.OrderDetails
                .Where(o => (o.OrderDetailId == id))
                .FirstOrDefault<OrderDetail>();
            }
        }

        public void Add(OrderDetail orderDetail)
        {
            using (var context = new Context())
            {
                context.OrderDetails.Attach(orderDetail);
                context.SaveChanges();
            }
        }

        public void Update(OrderDetail oldOrderDetail, OrderDetail newOrderDetail)
        {
            using (var context = new Context())
            {
                OrderDetail entity = GetById(oldOrderDetail.OrderDetailId);

                if (entity != null)
                {
                    entity.Quantity = newOrderDetail.Quantity;
                    entity.Product = newOrderDetail.Product;

                    var attach = context.OrderDetails.Attach(entity);
                    attach.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                    context.SaveChanges();
                }
            }
        }

        public void Delete(OrderDetail orderDetail)
        {
            using (var context = new Context())
            {
                context.OrderDetails.Remove(orderDetail);
                context.SaveChanges();
            }
        }

        public List<OrderDetail> Search(string searchString)
        {
            searchString = searchString.ToLower();

            using (var context = new Context())
            {

                return context.OrderDetails.Include(od => od.Order).Include(od => od.Product)
                    .Where(orderDetail =>
                        orderDetail.Product.ProductName.ToLower().Contains(searchString)
                    ).ToList();
            }
        }

        public Boolean IsValid(OrderDetail orderDetail)
        {
            return orderDetail.Quantity > 0 &&
              orderDetail.Product != null;
        }

    }
}
