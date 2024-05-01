using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EntityFrameworkCoreApp.Migrations
{
    /// <inheritdoc />
    public partial class IndexUnique : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Products",
                newName: "product_id");

            migrationBuilder.AlterColumn<string>(
                name: "product_name",
                table: "Products",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100,
                oldDefaultValue: "'Urun bilgisi girilmemis'");

            migrationBuilder.CreateIndex(
                name: "IX_Products_product_name",
                table: "Products",
                column: "product_name",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Products_product_name",
                table: "Products");

            migrationBuilder.RenameColumn(
                name: "product_id",
                table: "Products",
                newName: "Id");

            migrationBuilder.AlterColumn<string>(
                name: "product_name",
                table: "Products",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "'Urun bilgisi girilmemis'",
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);
        }
    }
}
