using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NekoQOLWebAPI.Migrations
{
    public partial class AddPlayerController : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Capes_HypixelPlayers_HypixelPlayerID",
                table: "Capes");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "HypixelPlayers",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "HypixelPlayerID",
                table: "Capes",
                newName: "HypixelPlayerId");

            migrationBuilder.RenameIndex(
                name: "IX_Capes_HypixelPlayerID",
                table: "Capes",
                newName: "IX_Capes_HypixelPlayerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Capes_HypixelPlayers_HypixelPlayerId",
                table: "Capes",
                column: "HypixelPlayerId",
                principalTable: "HypixelPlayers",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Capes_HypixelPlayers_HypixelPlayerId",
                table: "Capes");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "HypixelPlayers",
                newName: "ID");

            migrationBuilder.RenameColumn(
                name: "HypixelPlayerId",
                table: "Capes",
                newName: "HypixelPlayerID");

            migrationBuilder.RenameIndex(
                name: "IX_Capes_HypixelPlayerId",
                table: "Capes",
                newName: "IX_Capes_HypixelPlayerID");

            migrationBuilder.AddForeignKey(
                name: "FK_Capes_HypixelPlayers_HypixelPlayerID",
                table: "Capes",
                column: "HypixelPlayerID",
                principalTable: "HypixelPlayers",
                principalColumn: "ID");
        }
    }
}
