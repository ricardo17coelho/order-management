using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace order_management
{
    public class ProductCategoryRepository : Repository<ProductCategory>
    {

        public override void Add(ProductCategory entity)
        {
            dbContext.ProductCategories.Add(entity);
            Save();
        }

        public override void Remove(ProductCategory entity)
        {
            dbContext.ProductCategories.Remove(entity);
            Save();
        }

        public override BindingList<ProductCategory> GetBoundedList()
        {
            dbContext.ProductCategories.Load();
            return dbContext.ProductCategories.Local.ToBindingList();

        }

    }
}
