# 06 CTE – Categories View
```sql
var query = @";WITH RecurseTable " +
    "(ProductCategoryId, ProductCategoryName, ParentId, Level) " +
    "AS (SELECT " +
                "ProductCategoryId," +
                "ProductCategoryName," +
                "ISNULL(ParentId, 0)," +
                "0 AS Level " +
    "FROM ProductCategories " +
    "WHERE ParentId IS NULL " +
    "UNION ALL " +
    "SELECT " +
                "pcat.ProductCategoryId," +
                "pcat.ProductCategoryName," +
                "pcat.ParentId," +
                "Level + 1 " +
    "FROM ProductCategories AS pcat " +
    "INNER JOIN RecurseTable AS rec " +
        "ON rec.ProductCategoryId = pcat.ParentId " +
    ") " +
    "SELECT " +
            "ProductCategoryId," +
            "ProductCategoryName," +
            "ParentId," +
            "Level " +
    "FROM RecurseTable";
 ```
Die Aufruft von C# code erfolgt mit als Query string mit Hilfe von EntityFrameworkCore.
Danach erhalten wir als Ergebnis eine Tabelle mit ID der Kategory, Beschreibung, ParentID, welche Identifiziert zu welche übergeordnet Kategorie diese Kategorie gehört und als letzten mit «Level» wird angezeigt zu welchem Level sich diese Kategorie gehört.
Danach wird diese Liste iteriert. Als erstes nimmt man ein Node vom Level 0 und dann werden alle items mit dem gleichen ParentID zu diesen Node hinzugefügt bis alle items in der TreeView hinzugefügt wurden.
