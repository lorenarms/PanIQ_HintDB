using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PanIQ_HintDB.Data.Migrations
{
    public partial class AddHintDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
	        migrationBuilder.CreateTable(
		        name: "Hint",
		        columns: table => new
		        {
			        Id = table.Column<int>(type: "int", nullable: false).Annotation("SqlServer:Identity", "1, 1"),
			        Order = table.Column<int>(type: "int", nullable: false),
			        PuzzleId = table.Column<int>(type: "int", nullable: false),
					Text = table.Column<string>(type: "nvarchar(max)", nullable: false),
		        },
		        constraints: table =>
		        {
			        table.PrimaryKey("PK_Hint", x => x.Id);
			        table.ForeignKey(
				        name: "FK_Hint_Puzzle_PuzzleId",
				        column: x => x.PuzzleId,
				        principalTable: "Puzzle",
				        principalColumn: "Id",
				        onDelete: ReferentialAction.Cascade);
		        });
        }
	

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
