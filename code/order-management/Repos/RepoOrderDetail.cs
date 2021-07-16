using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace order_management
{
    public class RepoOrderDetail : RepoBase<OrderDetail>
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
