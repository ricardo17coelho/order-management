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
    public class CustomerRepository : Repository<Customer>
    {

        public override Customer FindById(int id)
        {
            return dbContext.Customers.Find(id);
        }

        public override void Add(Customer entity)
        {
            dbContext.Customers.Add(entity);
            Save();
        }

        public override void Remove(Customer entity)
        {
            dbContext.Customers.Remove(entity);
            Save();
        }

        public override BindingList<Customer> GetBoundedList()
        {
            dbContext.Customers.Load();
            return dbContext.Customers.Local.ToBindingList();

        }

    }
}
