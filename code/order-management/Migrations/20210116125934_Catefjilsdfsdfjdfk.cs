using Microsoft.EntityFrameworkCore.Migrations;

namespace order_management.Migrations
{
    public partial class Catefjilsdfsdfjdfk : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "City", "Country", "FirstName", "LastName", "Street", "StreetNr", "Zip" },
                values: new object[,]
                {
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
        }
    }
}
