using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace order_management
{
    public class ProductCategoryService : DbService
    {
        public static BindingList<ProductCategory> GetBoundedList(Context context)
        {
            context.ProductCategories.Load();
            return context.ProductCategories.Local.ToBindingList();
        }

        public static void Add(Context context, ProductCategory productCategory)
        {
            context.ProductCategories.Add(productCategory);
            context.SaveChanges();
        }

        public static void Remove(Context context, ProductCategory productCategory)
        {
            context.ProductCategories.Remove(productCategory);
            context.SaveChanges();
        }

        public static void RemoveAll(Context context)
        {
            context.ProductCategories.RemoveRange(context.ProductCategories);
            context.SaveChanges();
        }

        public static Boolean IsUnique(Context context, ProductCategory productCategory)
        {
            return !context.ProductCategories
                .Any(c => (c.ProductCategoryName == productCategory.ProductCategoryName));
        }

        public static Boolean IsValid(Context context, ProductCategory productCategory)
        {
            return productCategory.ProductCategoryName != "";
        }

        public static ProductCategory GetEntityByName(Context context, string name)
        {
            return context.ProductCategories
            .Where(pc => pc.ProductCategoryName == name)
            .FirstOrDefault<ProductCategory>();
        }
    }
}
