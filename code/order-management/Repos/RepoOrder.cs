using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace order_management
{
    public class RepoOrder : RepoBase<Order>
    {
        public RepoOrder(OrderManagementDbContext orderManagementDbContext) : base(orderManagementDbContext)
        {
        }
        public override IEnumerable<Order> GetAll()
        {

            return _orderManagementDbContext.Orders.Include(o => o.Customer).ToList();
        }

        public List<Order> Search(string searchString)
        {
            searchString = searchString.ToLower();

            return GetAll()
                .Where(order =>
                    order.Customer.FirstName.ToLower().Contains(searchString) ||
                    order.Customer.LastName.ToLower().Contains(searchString)
                ).ToList();
        }

        public Boolean IsUnique(Order order)
        {
            return !_orderManagementDbContext.Orders
            .Any(o => (o.Customer == order.Customer) &&
                (o.OrderDate == order.OrderDate));
        }

        public Boolean IsValid(Order order)
        {
            return order.OrderDate != null && order.Customer != null;
        }
    }
}
