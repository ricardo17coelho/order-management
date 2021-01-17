using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace order_management
{
    public class OrderService
    {
        public List<Order> GetAll()
        {
            using (var context = new Context())
            {
                return context.Orders.Include(o => o.Customer).ToList();
            }
        }

        public Order GetById(int id)
        {
            using (var context = new Context())
            {
                return context.Orders
                .Where(o => (o.OrderId == id))
                .FirstOrDefault<Order>();
            }
        }

        public Order Add(Order order)
        {
            using (var context = new Context())
            {
                var attach = context.Orders.Attach(order);
                context.SaveChanges();
                return attach.Entity;
            }
        }

        public void Update(Order oldOrder, Order newOrder)
        {
            using (var context = new Context())
            {
                Order entity = GetById(oldOrder.OrderId);

                if (entity != null)
                {
                    entity.Customer = newOrder.Customer;
                    entity.Tax = newOrder.Tax;
                    entity.OrderDate = newOrder.OrderDate;

                    var attach = context.Orders.Attach(entity);
                    attach.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                    context.SaveChanges();
                }
            }
        }

        public void Delete(Order order)
        {
            using (var context = new Context())
            {
                context.Orders.Remove(order);
                context.SaveChanges();
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
