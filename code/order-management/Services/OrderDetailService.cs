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
                return context.OrderDetails.Include(od => od.Order).Include(od => od.Product).Include(od => od.Order.Customer).ToList();
            }
        }

        //public Customer GetByName(string firstName, string lastName)
        //{
        //    using (var context = new Context())
        //    {
        //        return context.Customers
        //        .Where(c => (c.FirstName == firstName && c.LastName == c.LastName))
        //        .FirstOrDefault<Customer>();
        //    }
        //}

        public void Add(OrderDetail orderDetail)
        {
            using (var context = new Context())
            {
                context.OrderDetails.Attach(orderDetail);
                context.SaveChanges();
            }
        }

        //public void Update(Customer oldCustomer, Customer newCustomer)
        //{
        //    using (var context = new Context())
        //    {
        //        Customer entity = GetByName(oldCustomer.FirstName, oldCustomer.LastName);

        //        if (entity != null)
        //        {
        //            entity.FirstName = newCustomer.FirstName;
        //            entity.LastName = newCustomer.LastName;
        //            entity.Street = newCustomer.Street;
        //            entity.StreetNr = newCustomer.StreetNr;
        //            entity.Zip = newCustomer.Zip;
        //            entity.City = newCustomer.City;
        //            entity.Country = newCustomer.Country;

        //            var attach = context.Customers.Attach(entity);
        //            attach.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
        //            context.SaveChanges();
        //        }
        //    }
        //}

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

                //return context.OrderDetails.Include(od => od.Order).Include(od => od.Product).ToList();


                return context.OrderDetails.Include(od => od.Order).Include(od => od.Product)
                    .Where(orderDetail =>
                        orderDetail.Product.ProductName.ToLower().Contains(searchString)
                    ).ToList();
            }
        }

        //public Boolean IsUnique(Customer customer)
        //{
        //    using (var context = new Context())
        //    {
        //        return !context.Customers
        //        .Any(c => (c.FirstName == customer.FirstName) &&
        //          (c.LastName == customer.LastName));
        //    }
        //}

        //public Boolean IsValid(Customer customer)
        //{
        //    return customer.FirstName != "" &&
        //      customer.LastName != "";
        //}



























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
