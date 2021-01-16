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
    }
}
