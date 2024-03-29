﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace order_management
{
    public class RepoProductCategory : RepoBase<ProductCategory>
    {
        public RepoProductCategory(OrderManagementDbContext orderManagementDbContext) : base(orderManagementDbContext)
        {
        }

        public virtual ProductCategory GetByName(string name)
        {
            var table = _orderManagementDbContext.Set<ProductCategory>();
            return table
            .Where(pc => pc.ProductCategoryName == name)
            .FirstOrDefault<ProductCategory>();
        }

        public virtual List<ProductCategory> Search(string searchString)
        {
            searchString = searchString.ToLower();

            var table = _orderManagementDbContext.Set<ProductCategory>();
            return table
            .Where(category =>
                category.ProductCategoryName.ToLower().Contains(searchString)
            ).ToList();
        }

        public virtual List<ProductCategory> GetChildrenByParentId(int categoryId)
        {
            var table = _orderManagementDbContext.Set<ProductCategory>();
            return table
            .Where(pc => pc.ParentId == categoryId).ToList();
        }

        public virtual Boolean IsUnique(ProductCategory category)
        {
            var table = _orderManagementDbContext.Set<ProductCategory>();
            return !table
                .Any(c => (c.ProductCategoryName == category.ProductCategoryName));
        }

        public virtual Boolean IsValid(ProductCategory category)
        {
            return category.ProductCategoryName != "";
        }

        public virtual List<ProductCategory> GetCteDataForTreeView()
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

            var table = _orderManagementDbContext.Set<ProductCategory>();
            var result = table.FromSqlRaw(query);

            foreach (var item in result)
            {
                productCategories.Add(item);
            }

            return productCategories;
        }
    }
}
