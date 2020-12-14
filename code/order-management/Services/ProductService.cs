using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace order_management
{
    public class ProductService : DbService
    {
        public static BindingList<Product> GetBoundedList(Context context)
        {
            context.Products.Load();
            return context.Products.Local.ToBindingList();
        }

        public static void Add(Context context, Product product)
        {
            context.Products.Add(product);
            context.SaveChanges();
        }

        public static void Remove(Context context, Product product)
        {
            context.Products.Remove(product);
            context.SaveChanges();
        }

        public static void RemoveAll(Context context)
        {
            context.Products.RemoveRange(context.Products);
            context.SaveChanges();
        }

        public static Boolean IsUnique(Context context, Product product)
        {
            return !context.Products
                .Any(c => (c.ProductName == product.ProductName));
        }

        public static Boolean IsValid(Context context, Product product)
        {
            return product.ProductName != "";
        }
    }
}
