using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PanIQ_HintDB.Data.Migrations
{
    public partial class UpdateTablesAddPuzzlesLinkRoomsAndHints : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Hint_Rooms_RoomId",
                table: "Hint");

            migrationBuilder.RenameColumn(
                name: "RoomId",
                table: "Hint",
                newName: "PuzzleId");

            migrationBuilder.RenameIndex(
                name: "IX_Hint_RoomId",
                table: "Hint",
                newName: "IX_Hint_PuzzleId");

            migrationBuilder.AddColumn<int>(
                name: "Order",
                table: "Hint",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Puzzle",
                columns: table => new
                {
                    Id = table.Column<byte>(type: "tinyint", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RoomId = table.Column<byte>(type: "tinyint", nullable: false),
                    Order = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Puzzle", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Puzzle_Rooms_RoomId",
                        column: x => x.RoomId,
                        principalTable: "Rooms",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Puzzle_RoomId",
                table: "Puzzle",
                column: "RoomId");

            migrationBuilder.AddForeignKey(
                name: "FK_Hint_Puzzle_PuzzleId",
                table: "Hint",
                column: "PuzzleId",
                principalTable: "Puzzle",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Hint_Puzzle_PuzzleId",
                table: "Hint");

            migrationBuilder.DropTable(
                name: "Puzzle");

            migrationBuilder.DropColumn(
                name: "Order",
                table: "Hint");

            migrationBuilder.RenameColumn(
                name: "PuzzleId",
                table: "Hint",
                newName: "RoomId");

            migrationBuilder.RenameIndex(
                name: "IX_Hint_PuzzleId",
                table: "Hint",
                newName: "IX_Hint_RoomId");

            migrationBuilder.AddForeignKey(
                name: "FK_Hint_Rooms_RoomId",
                table: "Hint",
                column: "RoomId",
                principalTable: "Rooms",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
