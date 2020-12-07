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
    public class ProductRepository : Repository<Product>
    {

        public override void Add(Product entity)
        {
            dbContext.Products.Add(entity);
            Save();
        }

        public override void Remove(Product entity)
        {
            dbContext.Products.Remove(entity);
            Save();
        }

        public override BindingList<Product> GetBoundedList()
        {
            dbContext.Products.Load();
            return dbContext.Products.Local.ToBindingList();

        }

    }
}
