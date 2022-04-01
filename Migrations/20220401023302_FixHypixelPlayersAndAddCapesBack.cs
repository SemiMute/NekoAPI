using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NekoQOLWebAPI.Migrations
{
    public partial class FixHypixelPlayersAndAddCapesBack : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Capes_HypixelPlayers_HypixelPlayerId",
                table: "Capes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Capes",
                table: "Capes");

            migrationBuilder.RenameTable(
                name: "Capes",
                newName: "Cape");

            migrationBuilder.RenameIndex(
                name: "IX_Capes_HypixelPlayerId",
                table: "Cape",
                newName: "IX_Cape_HypixelPlayerId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Cape",
                table: "Cape",
                column: "CapeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Cape_HypixelPlayers_HypixelPlayerId",
                table: "Cape",
                column: "HypixelPlayerId",
                principalTable: "HypixelPlayers",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cape_HypixelPlayers_HypixelPlayerId",
                table: "Cape");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Cape",
                table: "Cape");

            migrationBuilder.RenameTable(
                name: "Cape",
                newName: "Capes");

            migrationBuilder.RenameIndex(
                name: "IX_Cape_HypixelPlayerId",
                table: "Capes",
                newName: "IX_Capes_HypixelPlayerId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Capes",
                table: "Capes",
                column: "CapeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Capes_HypixelPlayers_HypixelPlayerId",
                table: "Capes",
                column: "HypixelPlayerId",
                principalTable: "HypixelPlayers",
                principalColumn: "Id");
        }
    }
}
