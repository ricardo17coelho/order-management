using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using order_management.DbModels;

namespace order_management
{
    public class BillService
    {

        public List<Bill> GetBills()
        {
            List<Bill> objects = new List<Bill>();

            using (var context = new Context())
            {
                string query = @"SELECT    c.customerid, 
                                           c.firstname, 
                                           c.lastname, 
                                           c.street, 
                                           c.streetnr, 
                                           c.zip, 
                                           c.city, 
                                           c.country, 
                                           o.orderdate, 
                                           o.orderid, 
                                           Sum(od.quantity * p.price)                           AS Netto, 
                                           Sum(od.quantity * p.price) * ( ( o.tax / 100 ) + 1 ) AS Brutto 
                                    
                                    FROM   orders o 
                                           INNER JOIN orderdetails od 
                                                   ON o.orderid = od.orderid 
                                           INNER JOIN products p 
                                                   ON p.productid = od.productid 
                                           INNER JOIN productcategories pc 
                                                   ON pc.productcategoryid = p.productcategoryid 
                                           INNER JOIN customers c 
                                                   ON o.customerid = c.customerid 
                                    
                                    GROUP  BY o.orderid, 
                                              c.customerid, 
                                              c.firstname, 
                                              c.lastname, 
                                              c.street, 
                                              c.streetnr, 
                                              c.zip, 
                                              c.city, 
                                              c.country, 
                                              o.orderdate, 
                                              o.tax";

                IQueryable<Bill> result = context.Bills.FromSqlRaw(query);

                foreach (var item in result)
                {
                    objects.Add(item);
                }
                return objects;
            }
        }
    }
}
