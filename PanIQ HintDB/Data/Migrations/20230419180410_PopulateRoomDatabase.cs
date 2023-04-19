using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PanIQ_HintDB.Data.Migrations
{
    public partial class PopulateRoomDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
	        migrationBuilder.Sql("UPDATE Rooms SET Name = 'Wizard' WHERE Id = 1");
	        migrationBuilder.Sql("UPDATE Rooms SET Name = 'Casino' WHERE Id = 2");
	        migrationBuilder.Sql("UPDATE Rooms SET Name = 'Zombie' WHERE Id = 3");
	        migrationBuilder.Sql("UPDATE Rooms SET Name = 'Haunted' WHERE Id = 4");
	        migrationBuilder.Sql("UPDATE Rooms SET Name = 'Atlantis' WHERE Id = 5");
	        migrationBuilder.Sql("UPDATE Rooms SET Name = 'Time Machine' WHERE Id = 6");
	        migrationBuilder.Sql("UPDATE Rooms SET Name = 'Morning After' WHERE Id = 7");
			
		}

		protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
