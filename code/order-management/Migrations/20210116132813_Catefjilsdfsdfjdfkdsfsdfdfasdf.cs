using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace order_management.Migrations
{
    public partial class Catefjilsdfsdfjdfkdsfsdfdfasdf : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_ProductCategories_ProductCategoryId",
                table: "Products");

            migrationBuilder.AlterColumn<int>(
                name: "ProductCategoryId",
                table: "Products",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "Date", "Price", "ProductCategoryId", "ProductName", "Unit" },
                values: new object[,]
                {
                    { 1000, new DateTime(2018, 11, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 300.0, 1000, "HP Compaq 24 Inch", "Fr." },
                    { 1001, new DateTime(2019, 11, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 899.0, 1001, "Samsung 49HG90 49 Inch", "Fr." },
                    { 1002, new DateTime(2020, 11, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 60.0, 1003, "Logitech Ergonomic", "Fr." },
                    { 1003, new DateTime(2019, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 1200.0, 1006, "Super Chair 2000", "Fr." },
                    { 1004, new DateTime(2018, 11, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 50.0, 1006, "Bad Chaur 100", "Fr." },
                    { 1005, new DateTime(2019, 11, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 7000.0, 1007, "Nitro Concepts 300", "Fr." },
                    { 1006, new DateTime(2019, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 300.0, 1002, "Samsung super Curved Monitor 30 Inch", "Fr." },
                    { 1007, new DateTime(2018, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 2000.0, 1005, "Super Table", "Fr." },
                    { 1008, new DateTime(2018, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 250.0, 1005, "Bad Table", "Fr." }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Products_ProductCategories_ProductCategoryId",
                table: "Products",
                column: "ProductCategoryId",
                principalTable: "ProductCategories",
                principalColumn: "ProductCategoryId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_ProductCategories_ProductCategoryId",
                table: "Products");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1000);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1001);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1002);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1003);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1004);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1005);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1006);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1007);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1008);

            migrationBuilder.AlterColumn<int>(
                name: "ProductCategoryId",
                table: "Products",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_ProductCategories_ProductCategoryId",
                table: "Products",
                column: "ProductCategoryId",
                principalTable: "ProductCategories",
                principalColumn: "ProductCategoryId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
