using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace dona.Migrations
{
    /// <inheritdoc />
    public partial class WW : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "tblMenu",
                keyColumn: "MenuID",
                keyValue: 3,
                column: "ActionName",
                value: "Champions");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "tblMenu",
                keyColumn: "MenuID",
                keyValue: 3,
                column: "ActionName",
                value: "Index");
        }
    }
}
