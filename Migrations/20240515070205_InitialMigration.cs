using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace dona.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "tblMenu",
                columns: new[] { "MenuID", "ActionName", "CotrollerName", "IsActive", "Levers", "MenuName", "MenuOrder", "ParentID", "Position" },
                values: new object[,]
                {
                    { 1, null, null, true, 1, "Home", 1, 0, 1 },
                    { 2, null, null, true, 1, "Game", 2, 0, 1 },
                    { 3, null, null, true, 1, "Play", 3, 0, 1 },
                    { 4, null, null, true, 1, "New", 4, 0, 1 },
                    { 5, null, null, true, 1, "Blog", 5, 0, 1 },
                    { 6, null, null, true, 1, "About as", 6, 0, 1 },
                    { 7, null, null, true, 1, "pages", 7, 0, 1 },
                    { 8, null, null, true, 2, "contact", 1, 6, 1 },
                    { 9, null, null, true, 2, "blog", 2, 6, 1 },
                    { 10, null, null, true, 2, "acount", 3, 6, 1 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "tblMenu",
                keyColumn: "MenuID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "tblMenu",
                keyColumn: "MenuID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "tblMenu",
                keyColumn: "MenuID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "tblMenu",
                keyColumn: "MenuID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "tblMenu",
                keyColumn: "MenuID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "tblMenu",
                keyColumn: "MenuID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "tblMenu",
                keyColumn: "MenuID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "tblMenu",
                keyColumn: "MenuID",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "tblMenu",
                keyColumn: "MenuID",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "tblMenu",
                keyColumn: "MenuID",
                keyValue: 10);
        }
    }
}
