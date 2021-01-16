using Microsoft.EntityFrameworkCore.Migrations;

namespace order_management.Migrations
{
    public partial class Catefjilsdfsdfj : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "City", "Country", "FirstName", "LastName", "Street", "StreetNr", "Zip" },
                values: new object[] { 1, "Wil", "Schweiz", "Hans", "Müller", "Bahnhofstrasse", "12a", 9400 });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "City", "Country", "FirstName", "LastName", "Street", "StreetNr", "Zip" },
                values: new object[] { 2, "Uznach", "Schweiz", "Peter", "Haller", "Dorfstrasse", "5", 8452 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 2);
        }
    }
}
