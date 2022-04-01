using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NekoQOLWebAPI.Migrations
{
    public partial class InitComment : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "hypixelPlayers",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "TEXT", nullable: false),
                    DisplayName = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_hypixelPlayers", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "capes",
                columns: table => new
                {
                    CapeId = table.Column<string>(type: "TEXT", nullable: false),
                    HypixelPlayerID = table.Column<Guid>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_capes", x => x.CapeId);
                    table.ForeignKey(
                        name: "FK_capes_hypixelPlayers_HypixelPlayerID",
                        column: x => x.HypixelPlayerID,
                        principalTable: "hypixelPlayers",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateIndex(
                name: "IX_capes_HypixelPlayerID",
                table: "capes",
                column: "HypixelPlayerID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "capes");

            migrationBuilder.DropTable(
                name: "hypixelPlayers");
        }
    }
}
