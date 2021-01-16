using Microsoft.EntityFrameworkCore.Migrations;

namespace order_management.Migrations
{
    public partial class Catefjilsdfsdfjdfkdsfsdf : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 10);

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "City", "Country", "FirstName", "LastName", "Street", "StreetNr", "Zip" },
                values: new object[,]
                {
                    { 1000, "Wil", "Schweiz", "Hans", "Müller", "Bahnhofstrasse", "12a", 9400 },
                    { 1001, "Uznach", "Schweiz", "Peter", "Haller", "Dorfstrasse", "5", 8452 },
                    { 1002, "Zuckenriet", "Schweiz", "Ueli", "Moser", "Lindenstrasse", "27", 4524 },
                    { 1003, "Schlieren", "Schweiz", "Max", "Mustermann", "Bachweg", "1a", 4582 },
                    { 1004, "Walden", "Schweiz", "Vreni", "Kuster", "Hinter dem Baum", "12", 4521 },
                    { 1005, "Ederswiler", "Schweiz", "Petra", "Schwarz", "Blumenstrasse", "45b", 1234 },
                    { 1006, "Spreitebach", "Schweiz", "Andreas", "Rot", "Bahnhofplatz", "13", 9452 },
                    { 1007, "Mörschwil", "Schweiz", "Jürgen", "Blyatman", "Huebstrasse", "16", 9152 },
                    { 1008, "Interlaken", "Schweiz", "Oskar", "Kanban", "Rosenweg", "1b", 8523 },
                    { 1009, "Flieren", "Schweiz", "Karin", "Blattsalat", "Bachfeldstrasse", "5", 5423 }
                });

            migrationBuilder.InsertData(
                table: "ProductCategories",
                columns: new[] { "ProductCategoryId", "ParentId", "ProductCategoryName" },
                values: new object[] { 1000, null, "Computer Equipment" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 1000);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 1001);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 1002);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 1003);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 1004);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 1005);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 1006);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 1007);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 1008);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 1009);

            migrationBuilder.DeleteData(
                table: "ProductCategories",
                keyColumn: "ProductCategoryId",
                keyValue: 1000);

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "City", "Country", "FirstName", "LastName", "Street", "StreetNr", "Zip" },
                values: new object[,]
                {
                    { 1, "Wil", "Schweiz", "Hans", "Müller", "Bahnhofstrasse", "12a", 9400 },
                    { 2, "Uznach", "Schweiz", "Peter", "Haller", "Dorfstrasse", "5", 8452 },
                    { 3, "Zuckenriet", "Schweiz", "Ueli", "Moser", "Lindenstrasse", "27", 4524 },
                    { 4, "Schlieren", "Schweiz", "Max", "Mustermann", "Bachweg", "1a", 4582 },
                    { 5, "Walden", "Schweiz", "Vreni", "Kuster", "Hinter dem Baum", "12", 4521 },
                    { 6, "Ederswiler", "Schweiz", "Petra", "Schwarz", "Blumenstrasse", "45b", 1234 },
                    { 7, "Spreitebach", "Schweiz", "Andreas", "Rot", "Bahnhofplatz", "13", 9452 },
                    { 8, "Mörschwil", "Schweiz", "Jürgen", "Blyatman", "Huebstrasse", "16", 9152 },
                    { 9, "Interlaken", "Schweiz", "Oskar", "Kanban", "Rosenweg", "1b", 8523 },
                    { 10, "Flieren", "Schweiz", "Karin", "Blattsalat", "Bachfeldstrasse", "5", 5423 }
                });
        }
    }
}
