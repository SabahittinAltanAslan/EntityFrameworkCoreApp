using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EntityFrameworkCoreApp.Migrations
{
    /// <inheritdoc />
    public partial class AddTableFA : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Category",
                schema: "c",
                table: "Category");

            migrationBuilder.EnsureSchema(
                name: "dbo");

            migrationBuilder.RenameTable(
                name: "Category",
                schema: "c",
                newName: "Categories",
                newSchema: "dbo");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Categories",
                schema: "dbo",
                table: "Categories",
                column: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Categories",
                schema: "dbo",
                table: "Categories");

            migrationBuilder.EnsureSchema(
                name: "c");

            migrationBuilder.RenameTable(
                name: "Categories",
                schema: "dbo",
                newName: "Category",
                newSchema: "c");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Category",
                schema: "c",
                table: "Category",
                column: "Id");
        }
    }
}
