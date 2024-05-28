using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace dona.Migrations
{
    /// <inheritdoc />
    public partial class QQQ : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AdminMenu",
                keyColumn: "AdminMenuID",
                keyValue: 8L,
                column: "Icon",
                value: "bi bi-clipboard-data");

            migrationBuilder.UpdateData(
                table: "AdminMenu",
                keyColumn: "AdminMenuID",
                keyValue: 20L,
                column: "Icon",
                value: "bi bi-controller");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AdminMenu",
                keyColumn: "AdminMenuID",
                keyValue: 8L,
                column: "Icon",
                value: null);

            migrationBuilder.UpdateData(
                table: "AdminMenu",
                keyColumn: "AdminMenuID",
                keyValue: 20L,
                column: "Icon",
                value: null);
        }
    }
}
