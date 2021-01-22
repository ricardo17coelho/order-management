using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Windows.Forms;

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

        public List<ProductCategory> GetChildrenByParentId(int categoryId)
        {
            using (var context = new Context())
            {
                return context.ProductCategories
                    .Where(pc => pc.ParentId == categoryId).ToList();
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

        public List<ProductCategory> GetCteDataForTreeView()
        {
            var productCategories = new List<ProductCategory>();
            using (var context = new Context())
            {
                var query = @";WITH RecurseTable " +
                    "(ProductCategoryId, ProductCategoryName, ParentId, Level) " +
                    "AS (SELECT " +
                                "ProductCategoryId," +
                                "ProductCategoryName," +
                                "ISNULL(ParentId, 0)," +
                                "0 AS Level " +
                    "FROM ProductCategories " +
                    "WHERE ParentId IS NULL " +
                    "UNION ALL " +
                    "SELECT " +
                                "pcat.ProductCategoryId," +
                                "pcat.ProductCategoryName," +
                                "pcat.ParentId," +
                                "Level + 1 " +
                    "FROM ProductCategories AS pcat " +
                    "INNER JOIN RecurseTable AS rec " +
                        "ON rec.ProductCategoryId = pcat.ParentId " +
                    ") " +
                    "SELECT " +
                                "ProductCategoryId," +
                                "ProductCategoryName," +
                                "ParentId," +
                                "Level " +
                    "FROM RecurseTable";

                var result = context.ProductCategories.FromSqlRaw(query);

                foreach (var item in result)
                {
                    productCategories.Add(item);
                }
                return productCategories;
            }
        }
    }
}
