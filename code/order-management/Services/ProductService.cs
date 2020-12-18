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

        public static Product GetEntityById(Context context, int id)
        {
            return context.Products.Find(id);
        }

        public static Product GetEntityByName(Context context, string name)
        {
            return context.Products
            .Where(p => p.ProductName == name)
            .FirstOrDefault<Product>();
        }

        public static List<Product> GetProductsForCategory(Context context, ProductCategory category)
        {
            //TODO: This must be Recursive! (Maybe with CTE Magic?)
            return context.Products
            .Where(p => p.ProductCategoryId == category.ProductCategoryId).ToList();
        }
    }
}
