using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace order_management.Migrations
{
    public partial class ordermanagement : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Bills",
                columns: table => new
                {
                    BillId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerId = table.Column<int>(type: "int", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Street = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StreetNr = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Zip = table.Column<int>(type: "int", nullable: false),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Country = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OrderDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    OrderId = table.Column<int>(type: "int", nullable: false),
                    Netto = table.Column<double>(type: "float", nullable: false),
                    Brutto = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bills", x => x.BillId);
                });

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
                table: "Bills",
                columns: new[] { "BillId", "Brutto", "City", "Country", "CustomerId", "FirstName", "LastName", "Netto", "OrderDate", "OrderId", "Street", "StreetNr", "Zip" },
                values: new object[,]
                {
                    { 1004, 80.5, "Zuckenriet", "Schweiz", 1002, "Ueli", "Moser", 75.0, new DateTime(2020, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1007, "Lindenstrasse", "27", 4524 },
                    { 1003, 57.5, "Uznach", "Schweiz", 1001, "Peter", "Haller", 50.0, new DateTime(2020, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1002, "Dorfstrasse", "5", 8452 },
                    { 1002, 100.0, "Uznach", "Schweiz", 1001, "Peter", "Haller", 75.0, new DateTime(2019, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 1004, "Dorfstrasse", "5", 8452 },
                    { 1001, 215.19999999999999, "Wil", "Schweiz", 1000, "Hans", "Müller", 200.0, new DateTime(2020, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 1005, "Bahnhofstrasse", "12a", 9400 },
                    { 1000, 107.7, "Wil", "Schweiz", 1000, "Hans", "Müller", 100.0, new DateTime(2018, 11, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 1000, "Bahnhofstrasse", "12a", 9400 }
                });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "City", "Country", "FirstName", "LastName", "Street", "StreetNr", "Zip" },
                values: new object[,]
                {
                    { 1000, "Wil", "Schweiz", "Hans", "Müller", "Bahnhofstrasse", "12a", 9400 },
                    { 1009, "Flieren", "Schweiz", "Karin", "Blattsalat", "Bachfeldstrasse", "5", 5423 },
                    { 1008, "Interlaken", "Schweiz", "Oskar", "Kanban", "Rosenweg", "1b", 8523 },
                    { 1006, "Spreitebach", "Schweiz", "Andreas", "Rot", "Bahnhofplatz", "13", 9452 },
                    { 1005, "Ederswiler", "Schweiz", "Petra", "Schwarz", "Blumenstrasse", "45b", 1234 },
                    { 1004, "Walden", "Schweiz", "Vreni", "Kuster", "Hinter dem Baum", "12", 4521 },
                    { 1003, "Schlieren", "Schweiz", "Max", "Mustermann", "Bachweg", "1a", 4582 },
                    { 1002, "Zuckenriet", "Schweiz", "Ueli", "Moser", "Lindenstrasse", "27", 4524 },
                    { 1001, "Uznach", "Schweiz", "Peter", "Haller", "Dorfstrasse", "5", 8452 },
                    { 1007, "Mörschwil", "Schweiz", "Jürgen", "Blyatman", "Huebstrasse", "16", 9152 }
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
                    { 1000, 1000, 1001, 2 },
                    { 1022, 1007, 1004, 4 },
                    { 1009, 1003, 1004, 2 },
                    { 1008, 1002, 1004, 12 },
                    { 1001, 1000, 1004, 4 },
                    { 1027, 1010, 1003, 64 },
                    { 1021, 1007, 1003, 2 },
                    { 1007, 1002, 1003, 3 },
                    { 1004, 1000, 1003, 2 },
                    { 1023, 1007, 1008, 3 },
                    { 1014, 1004, 1008, 3 },
                    { 1013, 1004, 1008, 1 },
                    { 1005, 1001, 1008, 1 },
                    { 1030, 1010, 1007, 4 },
                    { 1012, 1004, 1007, 2 },
                    { 1025, 1009, 1002, 12 },
                    { 1020, 1006, 1002, 1 },
                    { 1015, 1005, 1002, 4 },
                    { 1003, 1000, 1002, 1 },
                    { 1029, 1010, 1001, 2 },
                    { 1024, 1008, 1001, 1 },
                    { 1019, 1006, 1001, 4 },
                    { 1017, 1005, 1001, 1 },
                    { 1016, 1005, 1001, 5 },
                    { 1006, 1001, 1001, 4 },
                    { 1026, 1009, 1004, 1 }
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
                values: new object[,]
                {
                    { 1011, 1003, 1006, 5 },
                    { 1018, 1005, 1006, 2 },
                    { 1028, 1010, 1006, 1 },
                    { 1002, 1000, 1005, 4 },
                    { 1010, 1003, 1005, 1 }
                });

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
                name: "Bills");

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
