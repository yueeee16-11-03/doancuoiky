using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace dona.Migrations
{
    /// <inheritdoc />
    public partial class LLL : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Lane",
                columns: table => new
                {
                    LaneID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Decriptions_Lane = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Images = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Link = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    author = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    createted_Date = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: true),
                    GameID = table.Column<long>(type: "bigint", nullable: true),
                    GamesGameID = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lane", x => x.LaneID);
                    table.ForeignKey(
                        name: "FK_Lane_Games_GamesGameID",
                        column: x => x.GamesGameID,
                        principalTable: "Games",
                        principalColumn: "GameID");
                });

            migrationBuilder.CreateTable(
                name: "PathChampions",
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
                    table.PrimaryKey("PK_PathChampions", x => x.PathID);
                    table.ForeignKey(
                        name: "FK_PathChampions_tblChampions_ChampionsID",
                        column: x => x.ChampionsID,
                        principalTable: "tblChampions",
                        principalColumn: "ChampionsID");
                });

            migrationBuilder.CreateTable(
                name: "SkinChampions",
                columns: table => new
                {
                    SkinID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nameskin = table.Column<string>(type: "nvarchar(max)", nullable: true),
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
                    table.PrimaryKey("PK_SkinChampions", x => x.SkinID);
                    table.ForeignKey(
                        name: "FK_SkinChampions_tblChampions_ChampionsID",
                        column: x => x.ChampionsID,
                        principalTable: "tblChampions",
                        principalColumn: "ChampionsID");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Lane_GamesGameID",
                table: "Lane",
                column: "GamesGameID");

            migrationBuilder.CreateIndex(
                name: "IX_PathChampions_ChampionsID",
                table: "PathChampions",
                column: "ChampionsID");

            migrationBuilder.CreateIndex(
                name: "IX_SkinChampions_ChampionsID",
                table: "SkinChampions",
                column: "ChampionsID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Lane");

            migrationBuilder.DropTable(
                name: "PathChampions");

            migrationBuilder.DropTable(
                name: "SkinChampions");
        }
    }
}
