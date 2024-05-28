using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace dona.Migrations
{
    /// <inheritdoc />
    public partial class Oaiiii : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AdminMenu",
                keyColumn: "AdminMenuID",
                keyValue: 8L,
                column: "ControllerName",
                value: "Champions");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AdminMenu",
                keyColumn: "AdminMenuID",
                keyValue: 8L,
                column: "ControllerName",
                value: "Home");
        }
    }
}
