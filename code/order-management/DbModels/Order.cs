using System;
using System.Collections.Generic;
using System.Text;

namespace order_management
{
    public class Order
    {
        public int OrderId { get; set; }
        public DateTime OrderDate { get; set; }
        public double Tax { get; set; }
        public virtual Customer Customer { get; set; }
        public virtual int CustomerId { get; set; }

        public Order(Customer customer, double tax, DateTime date)
        {
            OrderDate = date;
            Tax = tax;
            Customer = customer;
            CustomerId = customer.CustomerId;
        }

        public Order(int id, int customerId, DateTime date)
        {
            OrderId = id;
            OrderDate = date;
            Tax = 7.7;
            CustomerId = customerId;
        }

        public Order() { }

        public override string ToString()
        {
            return OrderDate.ToString();
        }

    }
}
