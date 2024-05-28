using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace dona.Migrations
{
    /// <inheritdoc />
    public partial class HHH : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description_destail",
                table: "tblChampions");

            migrationBuilder.DropColumn(
                name: "SkillsChampions",
                table: "tblChampions");

            migrationBuilder.DropColumn(
                name: "SkinChampions",
                table: "tblChampions");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Description_destail",
                table: "tblChampions",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SkillsChampions",
                table: "tblChampions",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SkinChampions",
                table: "tblChampions",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
