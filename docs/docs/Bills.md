# Bills
Zuerst haben wir das DataGridView für die Bills nur an ein Tabellen-Übergreifendes Query gebunden. Dann haben wir allerdings bemerkt, dass die Anforderung der nachvollziehbaren Adressänderung nicht erfüllt wird. 
Weil wenn man die Adresse eines Kunden geändert hat, hat sich auch die Adresse in den Bills geändert, da es ja nur eine Tabellenübergreifende Abfrage war.
Aufgrund dessen haben wir, wie man im ERM sehen kann, eine Tabelle für die Bills erstellt. Somit werden jetzt auch Rechnungen persistiert und man kann Adressänderungen nachvollziehen.

##	Netto Brutto Berechnung
Damit wir den Netto und Brutto Preis berechnen können, haben wir bei jedem Order-Objekt eine «Tax» definiert. 
```
double netto = 0;

foreach (var orderDetail in orderDetails)
{
netto += orderDetail.Quantity * orderDetail.Product.Price;
}

var brutto = netto * (order.Tax / 100) + netto;

Add(new Bill(customerId, firstName, lastName, street, streetNr, zip, city, country, orderDate, orderId, netto, brutto)) 
```

