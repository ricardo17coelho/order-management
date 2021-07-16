using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace order_management
{
    public class RepoOrder : RepoBase<Order>
    {
        public new List<Order> GetAll()
        {
            using (var context = new Context())
            {
                return context.Orders.Include(o => o.Customer).ToList();
            }
        }

        public List<Order> Search(string searchString)
        {
            searchString = searchString.ToLower();

            using (var context = new Context())
            {
                return GetAll()
                    .Where(order =>
                        order.Customer.FirstName.ToLower().Contains(searchString) ||
                        order.Customer.LastName.ToLower().Contains(searchString)
                    ).ToList();
            }
        }

        public Boolean IsUnique(Order order)
        {
            using (var context = new Context())
            {
                return !context.Orders
                .Any(o => (o.Customer == order.Customer) &&
                  (o.OrderDate == order.OrderDate));
            }
        }

        public Boolean IsValid(Order order)
        {
            return order.OrderDate != null && order.Customer != null;
        }
    }
}
