using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PanIQ_HintDB.Data.Migrations
{
    public partial class PopulateRoomsAndPuzzles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
	        migrationBuilder.Sql(@"
				
				INSERT INTO [dbo].[Rooms] ([Id], [Name]) VALUES (1, N'Wizard')
				INSERT INTO [dbo].[Rooms] ([Id], [Name]) VALUES (2, N'Casino')
				INSERT INTO [dbo].[Rooms] ([Id], [Name]) VALUES (3, N'Zombie')
				INSERT INTO [dbo].[Rooms] ([Id], [Name]) VALUES (4, N'Haunted')
				INSERT INTO [dbo].[Rooms] ([Id], [Name]) VALUES (5, N'Atlantis')
				INSERT INTO [dbo].[Rooms] ([Id], [Name]) VALUES (6, N'Time Machine')
				INSERT INTO [dbo].[Rooms] ([Id], [Name]) VALUES (7, N'Morning After')


				");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
