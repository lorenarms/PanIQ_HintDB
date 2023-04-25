using Humanizer;
using Microsoft.EntityFrameworkCore.Migrations;
using static Humanizer.In;

#nullable disable

namespace PanIQ_HintDB.Data.Migrations
{
    public partial class SeedHintDBStart : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
	        migrationBuilder.Sql(@"
				INSERT INTO [dbo].[Hint] ([Order], [PuzzleId], [Text]) VALUES (1, 2, N'""EXPLORE THAT BOOKSHELF A BIT MORE""')
				INSERT INTO [dbo].[Hint] ([Order], [PuzzleId], [Text]) VALUES (2, 2, N'PICTURE OF THE SKULL')
				INSERT INTO [dbo].[Hint] ([Order], [PuzzleId], [Text]) VALUES (3, 2, N'""TRY HOLDING THAT BUTTON IN THE SKULL DOWN FOR A MOMENT.""')


");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            
        }
    }
}
