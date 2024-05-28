using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace dona.Migrations
{
    /// <inheritdoc />
    public partial class LL : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SkillChampions",
                columns: table => new
                {
                    SkillID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nameskill = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Images = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    author = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    createted_Date = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: true),
                    ChampionsID = table.Column<long>(type: "bigint", nullable: true),
                    NameChampions = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SkillChampions", x => x.SkillID);
                    table.ForeignKey(
                        name: "FK_SkillChampions_tblChampions_ChampionsID",
                        column: x => x.ChampionsID,
                        principalTable: "tblChampions",
                        principalColumn: "ChampionsID");
                });

            migrationBuilder.CreateIndex(
                name: "IX_SkillChampions_ChampionsID",
                table: "SkillChampions",
                column: "ChampionsID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SkillChampions");
        }
    }
}
