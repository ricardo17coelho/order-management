using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace order_management
{
    public class OrderService : DbService
    {
        public static BindingList<Order> GetBoundedList(Context context)
        {
            context.Orders.Load();
            return context.Orders.Local.ToBindingList();
        }

        public static void Add(Context context, Order order)
        {
            context.Orders.Add(order);
            context.SaveChanges();
        }

        public static void Remove(Context context, Order order)
        {
            context.Orders.Remove(order);
            context.SaveChanges();
        }

        public static void RemoveAll(Context context)
        {
            context.Orders.RemoveRange(context.Orders);
            context.SaveChanges();
        }

        public static Boolean IsUnique(Context context, Order order)
        {
            return !context.Orders
                .Any(c => (c.OrderDate == order.OrderDate) &&
                  (c.CustomerId == order.CustomerId));
        }

        public static Boolean IsValid(Context context, Order order)
        {
            return order.OrderDate != null;
        }

        public static Order GetEntityById(Context context, int id)
        {
            return context.Orders.Find(id);
        }

        public static Order GetOrderByCustomer(Context context, Customer customer)
        {
            return context.Orders
            .Where(o => o.CustomerId == customer.CustomerId)
            .FirstOrDefault<Order>();
        }
    }
}
