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
        
        // Navigation Property
        public virtual Customer Customer { get; set; }

        // Navigation Property
        public virtual int CustomerId { get; set; }

        public Order(Customer customer)
        {
            OrderDate = DateTime.Now;
            Tax = 7.7;
            Customer = customer;
            CustomerId = customer.CustomerId;
        }

        public Order() { }
    }
}
