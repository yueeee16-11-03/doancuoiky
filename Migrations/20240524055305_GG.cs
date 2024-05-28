using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace dona.Migrations
{
    /// <inheritdoc />
    public partial class GG : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AdminMenu",
                keyColumn: "AdminMenuID",
                keyValue: 8L,
                column: "ControllerName",
                value: "Home");

            migrationBuilder.InsertData(
                table: "AdminMenu",
                columns: new[] { "AdminMenuID", "ActionName", "AreaName", "ControllerName", "Icon", "IdName", "IsActive", "ItemLever", "ItemName", "ItemOrder", "ItemTarget", "ParentLever" },
                values: new object[,]
                {
                    { 16L, "Index", "Admin", "Home", null, null, true, 2, "Champions", 2, null, 8 },
                    { 17L, "Index", "Admin", "Champions", null, null, true, 2, "Path", 1, null, 8 },
                    { 18L, "Index", "Admin", "Champions", null, null, true, 2, "Skill", 2, null, 8 },
                    { 19L, "Index", "Admin", "Champions", null, null, true, 2, "Skin", 3, null, 8 },
                    { 20L, "Index", "Admin", "Home", null, null, true, 1, "Games Management", 5, null, 0 },
                    { 21L, "Index", "Admin", "Game", null, null, true, 2, "Games", 3, null, 8 },
                    { 22L, "Index", "Admin", "Game", null, null, true, 2, "Lane", 3, null, 8 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AdminMenu",
                keyColumn: "AdminMenuID",
                keyValue: 16L);

            migrationBuilder.DeleteData(
                table: "AdminMenu",
                keyColumn: "AdminMenuID",
                keyValue: 17L);

            migrationBuilder.DeleteData(
                table: "AdminMenu",
                keyColumn: "AdminMenuID",
                keyValue: 18L);

            migrationBuilder.DeleteData(
                table: "AdminMenu",
                keyColumn: "AdminMenuID",
                keyValue: 19L);

            migrationBuilder.DeleteData(
                table: "AdminMenu",
                keyColumn: "AdminMenuID",
                keyValue: 20L);

            migrationBuilder.DeleteData(
                table: "AdminMenu",
                keyColumn: "AdminMenuID",
                keyValue: 21L);

            migrationBuilder.DeleteData(
                table: "AdminMenu",
                keyColumn: "AdminMenuID",
                keyValue: 22L);

            migrationBuilder.UpdateData(
                table: "AdminMenu",
                keyColumn: "AdminMenuID",
                keyValue: 8L,
                column: "ControllerName",
                value: "Champions");
        }
    }
}
