using Microsoft.EntityFrameworkCore.Migrations;

namespace order_management.Migrations
{
    public partial class Catefjilsdf : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductCategories_ProductCategories_ParentProductCategoryId",
                table: "ProductCategories");

            migrationBuilder.RenameColumn(
                name: "ParentProductCategoryId",
                table: "ProductCategories",
                newName: "ParentId");

            migrationBuilder.RenameIndex(
                name: "IX_ProductCategories_ParentProductCategoryId",
                table: "ProductCategories",
                newName: "IX_ProductCategories_ParentId");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductCategories_ProductCategories_ParentId",
                table: "ProductCategories",
                column: "ParentId",
                principalTable: "ProductCategories",
                principalColumn: "ProductCategoryId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductCategories_ProductCategories_ParentId",
                table: "ProductCategories");

            migrationBuilder.RenameColumn(
                name: "ParentId",
                table: "ProductCategories",
                newName: "ParentProductCategoryId");

            migrationBuilder.RenameIndex(
                name: "IX_ProductCategories_ParentId",
                table: "ProductCategories",
                newName: "IX_ProductCategories_ParentProductCategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductCategories_ProductCategories_ParentProductCategoryId",
                table: "ProductCategories",
                column: "ParentProductCategoryId",
                principalTable: "ProductCategories",
                principalColumn: "ProductCategoryId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
