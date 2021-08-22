using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace order_management
{
    public class RepoYoy : RepoBase<YoyComparison>
    {

        public List<YoyComparison> GetYoyComparison()
        {
            List<YoyComparison> objects = new List<YoyComparison>();

            using (var context = new Context())
            {
                string query = @"SELECT  Concat(Datepart(yyyy, o.orderdate), ' Q', Datepart(qq, o.orderdate)) AS Quarter, 
                                   Count(o.OrderId) AS CountOrders,
                                   avg(od.quantity) AS AvgCountProductsPerOrder,
                                   Sum(od.quantity * p.price) AS TotalRevenue
                            FROM   orders o 
                                   INNER JOIN orderdetails od 
                                           ON o.orderid = od.orderid 
                                   INNER JOIN products p 
                                           ON p.productid = od.productid 
                                   INNER JOIN productcategories pc 
                                           ON pc.productcategoryid = p.productcategoryid 
							WHERE DATEDIFF(YEAR, OrderDate, GETDATE()) <= 3
                            GROUP BY Concat(Datepart(yyyy, o.orderdate), ' Q', Datepart(qq, o.orderdate))
                            ORDER BY Concat(Datepart(yyyy, o.orderdate), ' Q', Datepart(qq, o.orderdate)) DESC;";

                IQueryable<YoyComparison> result = context.YoyComparisons.FromSqlRaw(query);

                foreach (var item in result)
                {
                    objects.Add(item);
                }
                return objects;
            }
        }
    }
}
