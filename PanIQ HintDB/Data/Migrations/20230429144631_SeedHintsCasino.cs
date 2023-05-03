using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PanIQ_HintDB.Data.Migrations
{
    public partial class SeedHintsCasino : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
	        migrationBuilder.Sql(@"

				INSERT INTO [dbo].[Hint] ([Order], [PuzzleId], [Text]) VALUES (1, 60, N'""TEXT""')	


				INSERT INTO [dbo].[Hint] ([Order], [PuzzleId], [Text]) VALUES (1, 60, N'""TEXT""')	


			");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
