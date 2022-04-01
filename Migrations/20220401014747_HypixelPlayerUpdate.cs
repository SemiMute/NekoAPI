using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NekoQOLWebAPI.Migrations
{
    public partial class HypixelPlayerUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_capes_hypixelPlayers_HypixelPlayerID",
                table: "capes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_hypixelPlayers",
                table: "hypixelPlayers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_capes",
                table: "capes");

            migrationBuilder.RenameTable(
                name: "hypixelPlayers",
                newName: "HypixelPlayers");

            migrationBuilder.RenameTable(
                name: "capes",
                newName: "Capes");

            migrationBuilder.RenameIndex(
                name: "IX_capes_HypixelPlayerID",
                table: "Capes",
                newName: "IX_Capes_HypixelPlayerID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_HypixelPlayers",
                table: "HypixelPlayers",
                column: "ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Capes",
                table: "Capes",
                column: "CapeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Capes_HypixelPlayers_HypixelPlayerID",
                table: "Capes",
                column: "HypixelPlayerID",
                principalTable: "HypixelPlayers",
                principalColumn: "ID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Capes_HypixelPlayers_HypixelPlayerID",
                table: "Capes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_HypixelPlayers",
                table: "HypixelPlayers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Capes",
                table: "Capes");

            migrationBuilder.RenameTable(
                name: "HypixelPlayers",
                newName: "hypixelPlayers");

            migrationBuilder.RenameTable(
                name: "Capes",
                newName: "capes");

            migrationBuilder.RenameIndex(
                name: "IX_Capes_HypixelPlayerID",
                table: "capes",
                newName: "IX_capes_HypixelPlayerID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_hypixelPlayers",
                table: "hypixelPlayers",
                column: "ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_capes",
                table: "capes",
                column: "CapeId");

            migrationBuilder.AddForeignKey(
                name: "FK_capes_hypixelPlayers_HypixelPlayerID",
                table: "capes",
                column: "HypixelPlayerID",
                principalTable: "hypixelPlayers",
                principalColumn: "ID");
        }
    }
}
