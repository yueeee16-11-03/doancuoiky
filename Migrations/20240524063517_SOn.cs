using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace dona.Migrations
{
    /// <inheritdoc />
    public partial class SOn : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AdminMenu",
                keyColumn: "AdminMenuID",
                keyValue: 17L,
                column: "ControllerName",
                value: "Path");

            migrationBuilder.UpdateData(
                table: "AdminMenu",
                keyColumn: "AdminMenuID",
                keyValue: 18L,
                column: "ControllerName",
                value: "Skills");

            migrationBuilder.UpdateData(
                table: "AdminMenu",
                keyColumn: "AdminMenuID",
                keyValue: 19L,
                column: "ControllerName",
                value: "Skins");

            migrationBuilder.UpdateData(
                table: "AdminMenu",
                keyColumn: "AdminMenuID",
                keyValue: 22L,
                column: "ControllerName",
                value: "Lane");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AdminMenu",
                keyColumn: "AdminMenuID",
                keyValue: 17L,
                column: "ControllerName",
                value: "Champions");

            migrationBuilder.UpdateData(
                table: "AdminMenu",
                keyColumn: "AdminMenuID",
                keyValue: 18L,
                column: "ControllerName",
                value: "Champions");

            migrationBuilder.UpdateData(
                table: "AdminMenu",
                keyColumn: "AdminMenuID",
                keyValue: 19L,
                column: "ControllerName",
                value: "Champions");

            migrationBuilder.UpdateData(
                table: "AdminMenu",
                keyColumn: "AdminMenuID",
                keyValue: 22L,
                column: "ControllerName",
                value: "Game");
        }
    }
}
