# YOY Comparison
##	Query
Der Jahresvergleich wurde mit SqlRaw umgesetzt. Es wäre zwar eleganter die Abfrage mit Linq umzusetzen, da wir jetzt diverse «Magic Strings» haben, aber es war im Auftrag nicht vorgegeben und wir wussten nicht genau, wie man so eine Komplexe Abfrage mit Linq nachbilden kann.

```
SELECT Concat(Datepart(yyyy, o.orderdate), ' Q', Datepart(qq, o.orderdate)) AS
       Quarter,
       Count(o.orderid)                                                     AS
       CountOrders,
       Avg(od.quantity)                                                     AS
       AvgCountProductsPerOrder,
       Sum(od.quantity * p.price)                                           AS
       TotalRevenue
FROM   orders o
       INNER JOIN orderdetails od
               ON o.orderid = od.orderid
       INNER JOIN products p
               ON p.productid = od.productid
       INNER JOIN productcategories pc
               ON pc.productcategoryid = p.productcategoryid
WHERE  Datediff(year, orderdate, Getdate()) <= 3
GROUP  BY Concat(Datepart(yyyy, o.orderdate), ' Q', Datepart(qq, o.orderdate))
ORDER  BY Concat(Datepart(yyyy, o.orderdate), ' Q', Datepart(qq, o.orderdate))
          DESC; 

```
##	Klasse
Für die einzelnen Spalten wurde eine Klasse erstellt:
```
public class YoyComparison
{
    public string Quarter { get; set; }
    public int CountOrders { get; set; }
    public int AvgCountProductsPerOrder { get; set; }
    public double TotalRevenue { get; set; }
}
```
Im DBContext haben wir definiert, dass für diese Klasse keine Tabelle generiert werden soll, da wir die Klasse nur als Objekt-Struktur für die Abfrage und für die Darstellung im DataGridView benötigen.
