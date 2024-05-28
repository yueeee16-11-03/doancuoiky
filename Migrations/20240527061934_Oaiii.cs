using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace dona.Migrations
{
    /// <inheritdoc />
    public partial class Oaiii : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SkillChampions");

            migrationBuilder.DropTable(
                name: "SkinChampions");

            migrationBuilder.CreateTable(
                name: "tblSkills",
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
                    table.PrimaryKey("PK_tblSkills", x => x.SkillID);
                    table.ForeignKey(
                        name: "FK_tblSkills_tblChampions_ChampionsID",
                        column: x => x.ChampionsID,
                        principalTable: "tblChampions",
                        principalColumn: "ChampionsID");
                });

            migrationBuilder.CreateTable(
                name: "tblSkins",
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
                    table.PrimaryKey("PK_tblSkins", x => x.SkinID);
                    table.ForeignKey(
                        name: "FK_tblSkins_tblChampions_ChampionsID",
                        column: x => x.ChampionsID,
                        principalTable: "tblChampions",
                        principalColumn: "ChampionsID");
                });

            migrationBuilder.CreateIndex(
                name: "IX_tblSkills_ChampionsID",
                table: "tblSkills",
                column: "ChampionsID");

            migrationBuilder.CreateIndex(
                name: "IX_tblSkins_ChampionsID",
                table: "tblSkins",
                column: "ChampionsID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tblSkills");

            migrationBuilder.DropTable(
                name: "tblSkins");

            migrationBuilder.CreateTable(
                name: "SkillChampions",
                columns: table => new
                {
                    SkillID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ChampionsID = table.Column<long>(type: "bigint", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Images = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: true),
                    NameChampions = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Nameskill = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    author = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    createted_Date = table.Column<DateTime>(type: "datetime2", nullable: true)
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

            migrationBuilder.CreateTable(
                name: "SkinChampions",
                columns: table => new
                {
                    SkinID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ChampionsID = table.Column<long>(type: "bigint", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Images = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: true),
                    NameChampions = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Nameskin = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    author = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    createted_Date = table.Column<DateTime>(type: "datetime2", nullable: true)
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
                name: "IX_SkillChampions_ChampionsID",
                table: "SkillChampions",
                column: "ChampionsID");

            migrationBuilder.CreateIndex(
                name: "IX_SkinChampions_ChampionsID",
                table: "SkinChampions",
                column: "ChampionsID");
        }
    }
}
