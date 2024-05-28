using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace dona.Migrations
{
    /// <inheritdoc />
    public partial class Ha : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PathChampions");

            migrationBuilder.CreateTable(
                name: "tblPath",
                columns: table => new
                {
                    PathID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Decriptions_Path = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NamePath = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Images = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Link = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    author = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    createted_Date = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: true),
                    NameChampions = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ChampionsID = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblPath", x => x.PathID);
                    table.ForeignKey(
                        name: "FK_tblPath_tblChampions_ChampionsID",
                        column: x => x.ChampionsID,
                        principalTable: "tblChampions",
                        principalColumn: "ChampionsID");
                });

            migrationBuilder.CreateIndex(
                name: "IX_tblPath_ChampionsID",
                table: "tblPath",
                column: "ChampionsID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tblPath");

            migrationBuilder.CreateTable(
                name: "PathChampions",
                columns: table => new
                {
                    PathID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ChampionsID = table.Column<long>(type: "bigint", nullable: true),
                    Decriptions_Path = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Images = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: true),
                    Link = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NameChampions = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NamePath = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    author = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    createted_Date = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PathChampions", x => x.PathID);
                    table.ForeignKey(
                        name: "FK_PathChampions_tblChampions_ChampionsID",
                        column: x => x.ChampionsID,
                        principalTable: "tblChampions",
                        principalColumn: "ChampionsID");
                });

            migrationBuilder.CreateIndex(
                name: "IX_PathChampions_ChampionsID",
                table: "PathChampions",
                column: "ChampionsID");
        }
    }
}
