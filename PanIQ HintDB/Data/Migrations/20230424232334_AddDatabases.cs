using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PanIQ_HintDB.Data.Migrations
{
    public partial class AddDatabases : Migration
    {
	    protected override void Up(MigrationBuilder migrationBuilder)
	    {
		    migrationBuilder.CreateTable(
			    name: "Rooms",
			    columns: table => new
			    {
					Id = table.Column<byte>(nullable: false),
					Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
					
				},
			    constraints: table =>
			    {
				    table.PrimaryKey("PK_Rooms", x => x.Id);

			    });

	    migrationBuilder.CreateTable(
				name: "Puzzle",
				columns: table => new
				{
					Id = table.Column<int>(type: "int", nullable: false).Annotation("SqlServer:Identity", "1, 1"),
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
		}

        protected override void Down(MigrationBuilder migrationBuilder)
        {
	        


		}
    }
}
