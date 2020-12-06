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
    public class CustomerRepository : IRepository<Customer>
    {

        private Context dbContext;

        public CustomerRepository()
        {
            this.dbContext = new Context();
        }

        public void Add(Customer customer)
        {
            dbContext.Customers.Add(customer);
            Save();
        }

        public void Remove(Customer customer)
        {
            dbContext.Customers.Remove(customer);
            Save();
        }

        public BindingList<Customer> GetBoundedList()
        {
            dbContext.Customers.Load();
            return dbContext.Customers.Local.ToBindingList();

        }

        public void Save()
        {
            dbContext.SaveChanges();
        }
    }
}
