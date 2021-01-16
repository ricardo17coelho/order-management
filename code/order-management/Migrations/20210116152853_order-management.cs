using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace order_management.Migrations
{
    public partial class ordermanagement : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    CustomerId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Street = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StreetNr = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Zip = table.Column<int>(type: "int", nullable: false),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Country = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.CustomerId);
                });

            migrationBuilder.CreateTable(
                name: "ProductCategories",
                columns: table => new
                {
                    ProductCategoryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductCategoryName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ParentId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductCategories", x => x.ProductCategoryId);
                    table.ForeignKey(
                        name: "FK_ProductCategories_ProductCategories_ParentId",
                        column: x => x.ParentId,
                        principalTable: "ProductCategories",
                        principalColumn: "ProductCategoryId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    OrderId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Tax = table.Column<double>(type: "float", nullable: false),
                    CustomerId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.OrderId);
                    table.ForeignKey(
                        name: "FK_Orders_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "CustomerId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    ProductId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<double>(type: "float", nullable: false),
                    Unit = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ProductCategoryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.ProductId);
                    table.ForeignKey(
                        name: "FK_Products_ProductCategories_ProductCategoryId",
                        column: x => x.ProductCategoryId,
                        principalTable: "ProductCategories",
                        principalColumn: "ProductCategoryId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OrderDetails",
                columns: table => new
                {
                    OrderDetailId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    OrderId = table.Column<int>(type: "int", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderDetails", x => x.OrderDetailId);
                    table.ForeignKey(
                        name: "FK_OrderDetails_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "OrderId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderDetails_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "ProductId",
                        onDelete: ReferentialAction.Cascade);
                });

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
                values: new object[,]
                {
                    { 1000, null, "Computer Equipment" },
                    { 1004, null, "Furniture" }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "OrderId", "CustomerId", "OrderDate", "Tax" },
                values: new object[,]
                {
                    { 1000, 1000, new DateTime(2018, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 7.7000000000000002 },
                    { 1001, 1000, new DateTime(2019, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 7.7000000000000002 },
                    { 1002, 1001, new DateTime(2020, 8, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 7.7000000000000002 },
                    { 1003, 1001, new DateTime(2019, 12, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 7.7000000000000002 },
                    { 1004, 1001, new DateTime(2018, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 7.7000000000000002 },
                    { 1005, 1003, new DateTime(2020, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 7.7000000000000002 },
                    { 1006, 1004, new DateTime(2019, 9, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 7.7000000000000002 },
                    { 1007, 1005, new DateTime(2018, 12, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 7.7000000000000002 },
                    { 1008, 1006, new DateTime(2020, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 7.7000000000000002 },
                    { 1009, 1007, new DateTime(2020, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 7.7000000000000002 },
                    { 1010, 1008, new DateTime(2019, 12, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 7.7000000000000002 }
                });

            migrationBuilder.InsertData(
                table: "ProductCategories",
                columns: new[] { "ProductCategoryId", "ParentId", "ProductCategoryName" },
                values: new object[,]
                {
                    { 1001, 1000, "Monitors" },
                    { 1003, 1000, "Keyboards" },
                    { 1005, 1004, "Tables" },
                    { 1006, 1004, "Chairs" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "Date", "Price", "ProductCategoryId", "ProductName", "Unit" },
                values: new object[] { 1000, new DateTime(2018, 11, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 300.0, 1000, "HP Compaq 24 Inch", "Fr." });

            migrationBuilder.InsertData(
                table: "OrderDetails",
                columns: new[] { "OrderDetailId", "OrderId", "ProductId", "Quantity" },
                values: new object[] { 1000, 1001, 1000, 1 });

            migrationBuilder.InsertData(
                table: "ProductCategories",
                columns: new[] { "ProductCategoryId", "ParentId", "ProductCategoryName" },
                values: new object[,]
                {
                    { 1002, 1001, "Curved" },
                    { 1007, 1006, "Office Chairs" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "Date", "Price", "ProductCategoryId", "ProductName", "Unit" },
                values: new object[,]
                {
                    { 1001, new DateTime(2019, 11, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 899.0, 1001, "Samsung 49HG90 49 Inch", "Fr." },
                    { 1002, new DateTime(2020, 11, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 60.0, 1003, "Logitech Ergonomic", "Fr." },
                    { 1007, new DateTime(2018, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 2000.0, 1005, "Super Table", "Fr." },
                    { 1008, new DateTime(2018, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 250.0, 1005, "Bad Table", "Fr." },
                    { 1003, new DateTime(2019, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 1200.0, 1006, "Super Chair 2000", "Fr." },
                    { 1004, new DateTime(2018, 11, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 50.0, 1006, "Bad Chaur 100", "Fr." }
                });

            migrationBuilder.InsertData(
                table: "OrderDetails",
                columns: new[] { "OrderDetailId", "OrderId", "ProductId", "Quantity" },
                values: new object[,]
                {
                    { 1001, 1001, 1001, 4 },
                    { 10010, 1007, 1002, 3 },
                    { 1007, 1004, 1007, 2 },
                    { 1008, 1005, 1008, 1 },
                    { 1009, 1006, 1008, 3 },
                    { 1002, 1002, 1003, 3 },
                    { 1003, 1002, 1004, 12 },
                    { 1004, 1003, 1004, 2 }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "Date", "Price", "ProductCategoryId", "ProductName", "Unit" },
                values: new object[,]
                {
                    { 1006, new DateTime(2019, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 300.0, 1002, "Samsung super Curved Monitor 30 Inch", "Fr." },
                    { 1005, new DateTime(2019, 11, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 7000.0, 1007, "Nitro Concepts 300", "Fr." }
                });

            migrationBuilder.InsertData(
                table: "OrderDetails",
                columns: new[] { "OrderDetailId", "OrderId", "ProductId", "Quantity" },
                values: new object[] { 1006, 1003, 1006, 5 });

            migrationBuilder.InsertData(
                table: "OrderDetails",
                columns: new[] { "OrderDetailId", "OrderId", "ProductId", "Quantity" },
                values: new object[] { 1005, 1003, 1005, 1 });

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetails_OrderId",
                table: "OrderDetails",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetails_ProductId",
                table: "OrderDetails",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_CustomerId",
                table: "Orders",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductCategories_ParentId",
                table: "ProductCategories",
                column: "ParentId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_ProductCategoryId",
                table: "Products",
                column: "ProductCategoryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OrderDetails");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "ProductCategories");
        }
    }
}
