using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace dona.Migrations
{
    /// <inheritdoc />
    public partial class FFa : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "PathID",
                table: "tblChampions",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PathID",
                table: "tblChampions");
        }
    }
}
