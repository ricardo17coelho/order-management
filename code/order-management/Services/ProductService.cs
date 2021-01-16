using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace order_management
{
    public class ProductService
    {
        public List<Product> GetAll()
        {
            using (var context = new Context())
            {
                return context.Products.Include(p => p.ProductCategory).ToList();
            }
        }

        public Product GetByName(string name)
        {
            using (var context = new Context())
            {
                return context.Products
                .Where(p => p.ProductName == name)
                .FirstOrDefault<Product>();
            }
        }

        public void Add(Product product)
        {
            using (var context = new Context())
            {
                context.Products.Attach(product);
                context.SaveChanges();
            }
        }

        public void Update(Product oldProduct, Product newProduct)
        {
            using (var context = new Context())
            {
                Product entity = GetByName(oldProduct.ProductName);

                if (entity != null)
                {
                    entity.ProductName = newProduct.ProductName;
                    entity.Price = newProduct.Price;
                    entity.Unit = newProduct.Unit;
                    entity.Date = newProduct.Date;
                    entity.ProductCategory = newProduct.ProductCategory;

                    var attach = context.Products.Attach(entity);
                    attach.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                    context.SaveChanges();
                }
            }
        }

        public void Delete(Product product)
        {
            using (var context = new Context())
            {
                context.Products.Remove(product);
                context.SaveChanges();
            }
        }

        public List<Product> Search(string searchString)
        {
            searchString = searchString.ToLower();

            using (var context = new Context())
            {
                return context.Products.Include(p => p.ProductCategory)
                    .Where(product =>
                        product.ProductName.ToLower().Contains(searchString)
                    ).ToList();
            }
        }

        public Boolean IsUnique(Product product)
        {
            using (var context = new Context())
            {
                return !context.Products
                .Any(c => (c.ProductName == product.ProductName));
            }
        }

        public Boolean IsValid(Product product)
        {
            return product.ProductName != "";
        }





































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

        //public static List<Product> GetProductsForCategory(Context context, ProductCategory category)
        //{
        //    //TODO: This must be Recursive! (Maybe with CTE Magic?)
        //    return context.Products
        //    .Where(p => p.ProductCategoryId == category.ProductCategoryId).ToList();
        //}
    }
}
