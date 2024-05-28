using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace dona.Migrations
{
    /// <inheritdoc />
    public partial class HH : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AdminMenu",
                keyColumn: "AdminMenuID",
                keyValue: 8L,
                columns: new[] { "IdName", "ItemTarget" },
                values: new object[] { "Champions", "Champions" });

            migrationBuilder.UpdateData(
                table: "AdminMenu",
                keyColumn: "AdminMenuID",
                keyValue: 20L,
                columns: new[] { "IdName", "ItemTarget" },
                values: new object[] { "Games", "Games" });

            migrationBuilder.UpdateData(
                table: "AdminMenu",
                keyColumn: "AdminMenuID",
                keyValue: 21L,
                column: "ParentLever",
                value: 20);

            migrationBuilder.UpdateData(
                table: "AdminMenu",
                keyColumn: "AdminMenuID",
                keyValue: 22L,
                column: "ParentLever",
                value: 20);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AdminMenu",
                keyColumn: "AdminMenuID",
                keyValue: 8L,
                columns: new[] { "IdName", "ItemTarget" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "AdminMenu",
                keyColumn: "AdminMenuID",
                keyValue: 20L,
                columns: new[] { "IdName", "ItemTarget" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "AdminMenu",
                keyColumn: "AdminMenuID",
                keyValue: 21L,
                column: "ParentLever",
                value: 8);

            migrationBuilder.UpdateData(
                table: "AdminMenu",
                keyColumn: "AdminMenuID",
                keyValue: 22L,
                column: "ParentLever",
                value: 8);
        }
    }
}
