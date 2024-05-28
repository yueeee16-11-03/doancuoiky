using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace dona.Migrations
{
    /// <inheritdoc />
    public partial class PP : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AdminMenu",
                keyColumn: "AdminMenuID",
                keyValue: 8L,
                columns: new[] { "ItemLever", "ItemName", "ItemOrder", "ParentLever" },
                values: new object[] { 1, "Champions Management", 4, 0 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AdminMenu",
                keyColumn: "AdminMenuID",
                keyValue: 8L,
                columns: new[] { "ItemLever", "ItemName", "ItemOrder", "ParentLever" },
                values: new object[] { 2, "Approve and Publish Post", 2, 6 });
        }
    }
}
