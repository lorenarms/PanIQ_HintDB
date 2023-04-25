using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PanIQ_HintDB.Data.Migrations
{
    public partial class SeedPuzzleDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
	        migrationBuilder.Sql(@"
				INSERT INTO [dbo].[Puzzle] ([Name], [RoomId], [Order]) VALUES (N'Close Professor Door', 6, 1)
				
				");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
