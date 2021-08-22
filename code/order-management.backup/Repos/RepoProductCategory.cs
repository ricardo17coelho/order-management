using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace order_management
{
    public class RepoProductCategory : RepoBase<ProductCategory>
    {
        public ProductCategory GetByName(string name)
        {
            using (var context = new Context())
            {
                var table = context.Set<ProductCategory>();
                return table
                .Where(pc => pc.ProductCategoryName == name)
                .FirstOrDefault<ProductCategory>();
            }
        }

        public List<ProductCategory> Search(string searchString)
        {
            searchString = searchString.ToLower();

            using (var context = new Context())
            {
                var table = context.Set<ProductCategory>();
                return table
                .Where(category =>
                    category.ProductCategoryName.ToLower().Contains(searchString)
                ).ToList();
            }
        }

        public List<ProductCategory> GetChildrenByParentId(int categoryId)
        {
            using (var context = new Context())
            {
                var table = context.Set<ProductCategory>();
                return table
                .Where(pc => pc.ParentId == categoryId).ToList();
            }
        }

        public Boolean IsUnique(ProductCategory category)
        {
            using (var context = new Context())
            {
                var table = context.Set<ProductCategory>();
                return !table
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

            using (var context = new Context())
            {
                var table = context.Set<ProductCategory>();
                var result = table.FromSqlRaw(query);

                foreach (var item in result)
                {
                    productCategories.Add(item);
                }

                return productCategories;
            }
        }
    }
}
