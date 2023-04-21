using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PanIQ_HintDB.Data.Migrations
{
    public partial class PopulateTimeMachinePuzzles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
	        migrationBuilder.Sql(
				"INSERT INTO [dbo].[Puzzle] ([Id], [Name], [RoomId], [Order]) VALUES (2, N'Cylinders', 6, 2)");
	        migrationBuilder.Sql(
		        "INSERT INTO [dbo].[Puzzle] ([Id], [Name], [RoomId], [Order]) VALUES (3, N'Valves', 6, 3)");
	        migrationBuilder.Sql(
		        "INSERT INTO [dbo].[Puzzle] ([Id], [Name], [RoomId], [Order]) VALUES (4, N'Energy Key', 6, 4)");
	        migrationBuilder.Sql(
		        "INSERT INTO [dbo].[Puzzle] ([Id], [Name], [RoomId], [Order]) VALUES (5, N'Air Flow Filter', 6, 5)");
	        migrationBuilder.Sql(
		        "INSERT INTO [dbo].[Puzzle] ([Id], [Name], [RoomId], [Order]) VALUES (6, N'Inverse Vault', 6, 6)");
	        migrationBuilder.Sql(
		        "INSERT INTO [dbo].[Puzzle] ([Id], [Name], [RoomId], [Order]) VALUES (7, N'Clock', 6, 7)");
	        migrationBuilder.Sql(
		        "INSERT INTO [dbo].[Puzzle] ([Id], [Name], [RoomId], [Order]) VALUES (8, N'Radium Ball', 6, 8)");
	        migrationBuilder.Sql(
		        "INSERT INTO [dbo].[Puzzle] ([Id], [Name], [RoomId], [Order]) VALUES (9, N'Matrix', 6, 9)");
	        migrationBuilder.Sql(
		        "INSERT INTO [dbo].[Puzzle] ([Id], [Name], [RoomId], [Order]) VALUES (10, N'Cog', 6, 10)");
	        migrationBuilder.Sql(
		        "INSERT INTO [dbo].[Puzzle] ([Id], [Name], [RoomId], [Order]) VALUES (11, N'Skull Eye', 6, 11)");
	        migrationBuilder.Sql(
		        "INSERT INTO [dbo].[Puzzle] ([Id], [Name], [RoomId], [Order]) VALUES (12, N'Prism', 6, 12)");
	        migrationBuilder.Sql(
		        "INSERT INTO [dbo].[Puzzle] ([Id], [Name], [RoomId], [Order]) VALUES (13, N'Footprints', 6, 13)");
	        migrationBuilder.Sql(
		        "INSERT INTO [dbo].[Puzzle] ([Id], [Name], [RoomId], [Order]) VALUES (14, N'Calculometer', 6, 14)");
	        migrationBuilder.Sql(
		        "INSERT INTO [dbo].[Puzzle] ([Id], [Name], [RoomId], [Order]) VALUES (15, N'Ignition', 6, 15)");
	        migrationBuilder.Sql(
		        "INSERT INTO [dbo].[Puzzle] ([Id], [Name], [RoomId], [Order]) VALUES (16, N'Control Panel', 6, 16)");
	        migrationBuilder.Sql(
		        "INSERT INTO [dbo].[Puzzle] ([Id], [Name], [RoomId], [Order]) VALUES (17, N'Time Capacitor', 6, 17)");
	        migrationBuilder.Sql(
		        "INSERT INTO [dbo].[Puzzle] ([Id], [Name], [RoomId], [Order]) VALUES (18, N'Machine Door', 6, 18)");

			
		}

		protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
