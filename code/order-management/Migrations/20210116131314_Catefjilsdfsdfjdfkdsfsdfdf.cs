using Microsoft.EntityFrameworkCore.Migrations;

namespace order_management.Migrations
{
    public partial class Catefjilsdfsdfjdfkdsfsdfdf : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "ProductCategories",
                columns: new[] { "ProductCategoryId", "ParentId", "ProductCategoryName" },
                values: new object[] { 1001, 1000, "Monitors" });

            migrationBuilder.InsertData(
                table: "ProductCategories",
                columns: new[] { "ProductCategoryId", "ParentId", "ProductCategoryName" },
                values: new object[] { 1003, 1000, "Keyboards" });

            migrationBuilder.InsertData(
                table: "ProductCategories",
                columns: new[] { "ProductCategoryId", "ParentId", "ProductCategoryName" },
                values: new object[] { 1004, null, "Furniture" });

            migrationBuilder.InsertData(
                table: "ProductCategories",
                columns: new[] { "ProductCategoryId", "ParentId", "ProductCategoryName" },
                values: new object[] { 1002, 1001, "Curved" });

            migrationBuilder.InsertData(
                table: "ProductCategories",
                columns: new[] { "ProductCategoryId", "ParentId", "ProductCategoryName" },
                values: new object[] { 1005, 1004, "Tables" });

            migrationBuilder.InsertData(
                table: "ProductCategories",
                columns: new[] { "ProductCategoryId", "ParentId", "ProductCategoryName" },
                values: new object[] { 1006, 1004, "Chairs" });

            migrationBuilder.InsertData(
                table: "ProductCategories",
                columns: new[] { "ProductCategoryId", "ParentId", "ProductCategoryName" },
                values: new object[] { 1007, 1006, "Office Chairs" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ProductCategories",
                keyColumn: "ProductCategoryId",
                keyValue: 1002);

            migrationBuilder.DeleteData(
                table: "ProductCategories",
                keyColumn: "ProductCategoryId",
                keyValue: 1003);

            migrationBuilder.DeleteData(
                table: "ProductCategories",
                keyColumn: "ProductCategoryId",
                keyValue: 1005);

            migrationBuilder.DeleteData(
                table: "ProductCategories",
                keyColumn: "ProductCategoryId",
                keyValue: 1007);

            migrationBuilder.DeleteData(
                table: "ProductCategories",
                keyColumn: "ProductCategoryId",
                keyValue: 1001);

            migrationBuilder.DeleteData(
                table: "ProductCategories",
                keyColumn: "ProductCategoryId",
                keyValue: 1006);

            migrationBuilder.DeleteData(
                table: "ProductCategories",
                keyColumn: "ProductCategoryId",
                keyValue: 1004);
        }
    }
}
