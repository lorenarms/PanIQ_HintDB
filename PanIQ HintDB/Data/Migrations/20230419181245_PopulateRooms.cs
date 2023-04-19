using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PanIQ_HintDB.Data.Migrations
{
    public partial class PopulateRooms : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
	        migrationBuilder.Sql("INSERT INTO Rooms (Id, Name) VALUES (1, 'Wizard')");
	        migrationBuilder.Sql("INSERT INTO Rooms (Id, Name) VALUES (2, 'Casino')");
	        migrationBuilder.Sql("INSERT INTO Rooms (Id, Name) VALUES (3, 'Zombie')");
	        migrationBuilder.Sql("INSERT INTO Rooms (Id, Name) VALUES (4, 'Haunted')");
	        migrationBuilder.Sql("INSERT INTO Rooms (Id, Name) VALUES (5, 'Atlantis')");
	        migrationBuilder.Sql("INSERT INTO Rooms (Id, Name) VALUES (6, 'Time Machine')");
	        migrationBuilder.Sql("INSERT INTO Rooms (Id, Name) VALUES (7, 'Morning After')");



		}

		protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
