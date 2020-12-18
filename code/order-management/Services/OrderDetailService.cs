using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace order_management
{
    public class OrderDetailService : DbService
    {
        public static BindingList<OrderDetail> GetBoundedList(Context context)
        {
            context.OrderDetails.Load();
            return context.OrderDetails.Local.ToBindingList();
        }

        public static void Add(Context context, OrderDetail orderDetail)
        {
            context.OrderDetails.Add(orderDetail);
            context.SaveChanges();
        }

        public static void Remove(Context context, OrderDetail orderDetail)
        {
            context.OrderDetails.Remove(orderDetail);
            context.SaveChanges();
        }

        public static void RemoveAll(Context context)
        {
            context.OrderDetails.RemoveRange(context.OrderDetails);
            context.SaveChanges();
        }

        public static Boolean IsUnique(Context context, OrderDetail orderDetail)
        {
            return !context.OrderDetails
                .Any(od => (od.OrderId == orderDetail.OrderId) &&
                  (od.ProductId == od.ProductId));
        }

        public static Boolean IsValid(Context context, OrderDetail order)
        {
            return order.Quantity != 0;
        }

        public static OrderDetail GetEntityById(Context context, int id)
        {
            return context.OrderDetails.Find(id);
        }
    }
}
