using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace dona.Migrations
{
    /// <inheritdoc />
    public partial class KK : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AdminMenu",
                columns: table => new
                {
                    AdminMenuID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ItemName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ItemLever = table.Column<int>(type: "int", nullable: false),
                    ParentLever = table.Column<int>(type: "int", nullable: false),
                    ItemOrder = table.Column<int>(type: "int", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: true),
                    ItemTarget = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AreaName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ControllerName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ActionName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Icon = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IdName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AdminMenu", x => x.AdminMenuID);
                });

            migrationBuilder.CreateTable(
                name: "tblMenu",
                columns: table => new
                {
                    MenuID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MenuName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: true),
                    CotrollerName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ActionName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Levels = table.Column<int>(type: "int", nullable: false),
                    Link = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ParentID = table.Column<int>(type: "int", nullable: false),
                    MenuOrder = table.Column<int>(type: "int", nullable: false),
                    Position = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblMenu", x => x.MenuID);
                });

            migrationBuilder.CreateTable(
                name: "tblPost",
                columns: table => new
                {
                    PostID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Abstract = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Contents = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Images = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Link = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    author = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    createted_Date = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: true),
                    PostOrder = table.Column<int>(type: "int", nullable: false),
                    MenuID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblPost", x => x.PostID);
                });

            migrationBuilder.CreateTable(
                name: "viewPostMenu",
                columns: table => new
                {
                    PostID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Abstract = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Contents = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Images = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Link = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    author = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    createted_Date = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: true),
                    PostOrder = table.Column<int>(type: "int", nullable: false),
                    MenuID = table.Column<int>(type: "int", nullable: false),
                    MenuName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_viewPostMenu", x => x.PostID);
                    table.ForeignKey(
                        name: "FK_viewPostMenu_tblMenu_MenuID",
                        column: x => x.MenuID,
                        principalTable: "tblMenu",
                        principalColumn: "MenuID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AdminMenu",
                columns: new[] { "AdminMenuID", "ActionName", "AreaName", "ControllerName", "Icon", "IdName", "IsActive", "ItemLever", "ItemName", "ItemOrder", "ItemTarget", "ParentLever" },
                values: new object[,]
                {
                    { 1L, "Index", "Admin", "Home", null, null, false, 0, "Dashboard", 1, null, 0 },
                    { 2L, "Index", "Admin", "Home", null, null, false, 0, "Profile", 1, null, 0 },
                    { 3L, "Index", "Admin", "Home", null, null, false, 0, "Directions", 2, null, 0 },
                    { 4L, "Index", "Admin", "Home", null, null, false, 0, "Contact", 3, null, 0 },
                    { 5L, "Index", "Admin", "Home", null, null, false, 0, "Log out", 4, null, 0 },
                    { 6L, "Index", "Admin", "Home", "bi bi-menu-button-wide", "components-nav", true, 1, "Post Management", 1, "components-nav", 0 },
                    { 7L, "Index", "Admin", "Post", null, null, true, 2, "Update Post", 1, null, 6 },
                    { 8L, "Index", "Admin", "Home", null, null, true, 2, "Approve and Publish Post", 2, null, 6 },
                    { 9L, "Index", "Admin", "Home", null, null, true, 2, "Published Posts", 3, null, 6 },
                    { 10L, "Index", "Admin", "Home", "bi bi-journal-text", "forms-nav", true, 1, "Menu Management", 1, "forms-nav", 0 },
                    { 11L, "Index", "Admin", "Menu", null, null, true, 2, "Add New Menu", 1, null, 10 },
                    { 12L, "Index", "Admin", "Home", null, null, true, 2, "Edit Menu", 2, null, 10 },
                    { 13L, "Index", "Admin", "Home", "bi bi-bar-chart", "charts-nav", true, 1, "Slide Management ", 1, "charts-nav", 0 },
                    { 14L, "Index", "Admin", "Home", null, null, true, 2, "Add New Slide", 1, null, 13 },
                    { 15L, "Index", "Admin", "Home", null, null, true, 2, "Edit Slide", 2, null, 13 }
                });

            migrationBuilder.InsertData(
                table: "tblMenu",
                columns: new[] { "MenuID", "ActionName", "CotrollerName", "IsActive", "Levels", "Link", "MenuName", "MenuOrder", "ParentID", "Position" },
                values: new object[,]
                {
                    { 1, null, null, true, 1, null, "Home", 1, 0, 1 },
                    { 2, null, null, true, 1, null, "Game", 2, 0, 1 },
                    { 3, "Index", "Champions", true, 1, null, "Champions", 3, 0, 1 },
                    { 4, null, null, true, 1, null, "New", 4, 0, 1 },
                    { 5, null, null, true, 1, null, "About as", 6, 0, 1 },
                    { 6, null, null, true, 2, null, "Riot Games", 1, 4, 1 },
                    { 7, null, null, true, 2, null, "Game UpDate", 2, 4, 1 },
                    { 8, null, null, true, 2, null, "EsPorts", 3, 4, 1 },
                    { 9, null, null, true, 2, null, "Lore", 4, 4, 1 },
                    { 10, null, null, true, 2, null, "Community", 5, 4, 1 },
                    { 11, null, null, true, 2, null, "Merch", 6, 4, 1 }
                });

            migrationBuilder.InsertData(
                table: "tblPost",
                columns: new[] { "PostID", "Abstract", "Contents", "Images", "IsActive", "Link", "MenuID", "PostOrder", "Title", "author", "createted_Date" },
                values: new object[,]
                {
                    { 1L, null, null, "images1/anh1.jpg", true, "https://www.youtube.com/watch?v=gicjDRPN-5E", 7, 1, "The Unlock | Xbox Game Pass", "oai", new DateTime(2024, 6, 10, 8, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2L, null, null, "images1/anh2.jpg", true, "https://www.riotgames.com/en/news/now-streaming-on-riot-mobile", 7, 2, "Now Streaming on Riot Mobile", "oai", new DateTime(2024, 5, 12, 10, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3L, null, null, "images1/anh3.jpg", true, "https://www.riotgames.com/en/news/link-riot-account-to-xbox-game-pass", 7, 3, "Link Riot Account with Xbox Game Pass Today to Unlock Benefits", "oai", new DateTime(2024, 5, 12, 10, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "viewPostMenu",
                columns: new[] { "PostID", "Abstract", "Contents", "Images", "IsActive", "Link", "MenuID", "MenuName", "PostOrder", "Title", "author", "createted_Date" },
                values: new object[,]
                {
                    { 1L, "TFT UPDATE VERISON ", "With 14.10 we asked ourselves, “What's not working?” and after reworking Lissandra, nerfing a few overperformers, and making Prismatic Orbs feel more like rare high rolls, we set out to make the not working stuff, well… work better.", "Image/anh1.jpg", true, null, 7, "Game UpDate", 1, "TEAMFIGHT TACTICS PATCH 14.10 NOTES", "oai", new DateTime(2024, 5, 10, 8, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2L, "We have quite a bit of stuff dropping in patch 14.10 ", "We have quite a bit of stuff dropping in patch 14.10: Split 1 end and Split 2 start details", "Image/anh2.jpg", true, null, 7, "Game UpDate", 2, "PATCH 14.10 NOTES", "oai", new DateTime(2024, 5, 10, 10, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3L, null, null, "Image/anh3.jpg", true, "https://www.youtube.com/watch?v=oJl_MKDUHqU", 8, "EsPorts", 3, "STAYING THE COURSE |MSI 2024", "oai", new DateTime(2024, 5, 10, 11, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4L, null, null, "Image/anh4.jpg", true, "https://www.youtube.com/watch?v=8rPhx_W6YDE", 8, "EsPorts", 4, "TOP 5 PLAYS|BRACKET STAGE WK1", "oai", new DateTime(2024, 5, 10, 13, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 5L, "In the beginning, the First Star gave birth to the universe and all life", " To protect its creations and ensure the cycle of life would continue for eternity, the First Star entrusted individuals iron-willed and pure of heart with fragments of its essence—starlight—as protectors of the universe throughout the ages.", "Image/anh5.jpg", true, null, 9, "Lore", 5, "PREVIOUSLY ON STAR GUARDIAN", "oai", new DateTime(2024, 5, 10, 13, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 6L, "Camavor is a brutal land with a bloody legacy", " Kalista seeks to change that. When her young and narcissistic uncle, Viego, becomes king she vows to temper his destructive instincts as his loyal confidant, advisor, and military general.", "Image/anh6.jpg", true, null, 9, "Lore", 6, "A LEAGUE OF LEGENDS NOVEL", "oai", new DateTime(2024, 5, 10, 14, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 7L, "There’s a lot going on for Pride this year across all our games", "Pride content hits the Rift with Patch 14.11 and is available until Patch 14.12’s conclusion. The event brings a new mission and Pride Emote, “United,” featuring Twisted Fate and Neeko, as well as returning Pride emotes for 1 Blue Essence each—essence-ially free!", "Image/anh7.jpg", true, null, 10, "Community", 7, "CELEBRATE PRIDE 2024: LEAGUE AND TFT", "oai", new DateTime(2024, 5, 10, 15, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 8L, "Calling all cosplayers, fan artists, and creators of all kinds", "Calling all cosplayers, fan artists, and creators of all kinds! We've got a gallery of reference images for the champions featured in our latest cinematic", "Image/anh8.jpg", true, null, 10, "Community", 8, "STILL HERE REFERENCE MATERIALS", "oai", new DateTime(2024, 5, 10, 16, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 9L, null, null, "Image/anh9.jpg", true, "https://www.youtube.com/watch?v=-KHMMMHvDdM", 6, "Riot Games", 9, "THE MAGESEEKER : A LEAGUE OF  LEGENDS STORY GAMEPLAY", "oai", new DateTime(2024, 5, 10, 17, 10, 0, 0, DateTimeKind.Unspecified) },
                    { 10L, null, null, "Image/anh10.jpg", true, "https://www.youtube.com/watch?v=n66QyujLXyg", 6, "Riot Games", 10, "RIOT FORGE GAMES 2023|THE YEAR AHEAD", "oai", new DateTime(2024, 5, 10, 17, 11, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.CreateIndex(
                name: "IX_viewPostMenu_MenuID",
                table: "viewPostMenu",
                column: "MenuID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AdminMenu");

            migrationBuilder.DropTable(
                name: "tblPost");

            migrationBuilder.DropTable(
                name: "viewPostMenu");

            migrationBuilder.DropTable(
                name: "tblMenu");
        }
    }
}
