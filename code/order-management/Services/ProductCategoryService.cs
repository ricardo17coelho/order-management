using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace order_management
{
    public class ProductCategoryService
    {
        public List<ProductCategory> GetAll()
        {
            using (var context = new Context())
            {
                return context.ProductCategories.ToList();
            }
        }

        public ProductCategory GetByName(string name)
        {
            using (var context = new Context())
            {
                return context.ProductCategories
                .Where(pc => pc.ProductCategoryName == name)
                .FirstOrDefault<ProductCategory>();
            }
        }

        public void Add(ProductCategory category)
        {
            using (var context = new Context())
            {
                context.ProductCategories.Attach(category);
                context.SaveChanges();
            }
        }

        public void Update(ProductCategory oldCategory, ProductCategory newCategory)
        {
            using (var context = new Context())
            {
                ProductCategory entity = GetByName(oldCategory.ProductCategoryName);

                if (entity != null)
                {
                    entity.ProductCategoryName = newCategory.ProductCategoryName;
                    entity.Parent = newCategory.Parent;

                    var attach = context.ProductCategories.Attach(entity);
                    attach.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                    context.SaveChanges();
                }
            }
        }

        public void Delete(ProductCategory category)
        {
            using (var context = new Context())
            {
                context.ProductCategories.Remove(category);
                context.SaveChanges();
            }
        }

        public List<ProductCategory> Search(string searchString)
        {
            searchString = searchString.ToLower();

            using (var context = new Context())
            {
                return context.ProductCategories
                    .Where(category =>
                        category.ProductCategoryName.ToLower().Contains(searchString)
                    ).ToList();
            }
        }

        public Boolean IsUnique(ProductCategory category)
        {
            using (var context = new Context())
            {
                return !context.ProductCategories
                .Any(c => (c.ProductCategoryName == category.ProductCategoryName));
            }
        }

        public Boolean IsValid(ProductCategory category)
        {
            return category.ProductCategoryName != "";
        }



















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

        public static ProductCategory GetEntityById(Context context, int id)
        {
            return context.ProductCategories.Find(id);
        }

        public static ProductCategory GetEntityByName(Context context, string name)
        {
            return context.ProductCategories
            .Where(pc => pc.ProductCategoryName == name)
            .FirstOrDefault<ProductCategory>();
        }

    }
}
