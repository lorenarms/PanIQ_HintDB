using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PanIQ_HintDB.Data.Migrations
{
    public partial class SeedPuzzleDBMore : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
	        migrationBuilder.Sql(@"
				INSERT INTO [dbo].[Puzzle] ([Name], [RoomId], [Order]) VALUES (N'Pressure Valves', 6, 4)
				INSERT INTO [dbo].[Puzzle] ([Name], [RoomId], [Order]) VALUES (N'Energy Key', 6, 5)
				INSERT INTO [dbo].[Puzzle] ([Name], [RoomId], [Order]) VALUES (N'Air Flow Filter', 6, 6)
				INSERT INTO [dbo].[Puzzle] ([Name], [RoomId], [Order]) VALUES (N'Inverse Vault', 6, 7)
				INSERT INTO [dbo].[Puzzle] ([Name], [RoomId], [Order]) VALUES (N'Clock', 6, 9)
				INSERT INTO [dbo].[Puzzle] ([Name], [RoomId], [Order]) VALUES (N'Radium Ball', 6, 10)
				INSERT INTO [dbo].[Puzzle] ([Name], [RoomId], [Order]) VALUES (N'Radium Matrix', 6, 11)
				INSERT INTO [dbo].[Puzzle] ([Name], [RoomId], [Order]) VALUES (N'Radium Cog', 6, 12)
				INSERT INTO [dbo].[Puzzle] ([Name], [RoomId], [Order]) VALUES (N'Prism', 6, 14)
				INSERT INTO [dbo].[Puzzle] ([Name], [RoomId], [Order]) VALUES (N'Footprints', 6, 15)
				INSERT INTO [dbo].[Puzzle] ([Name], [RoomId], [Order]) VALUES (N'Calculometer', 6, 16)
				INSERT INTO [dbo].[Puzzle] ([Name], [RoomId], [Order]) VALUES (N'Ignition', 6, 17)
				INSERT INTO [dbo].[Puzzle] ([Name], [RoomId], [Order]) VALUES (N'Control Panel', 6, 18)
				INSERT INTO [dbo].[Puzzle] ([Name], [RoomId], [Order]) VALUES (N'Time Capacitor', 6, 19)
				INSERT INTO [dbo].[Puzzle] ([Name], [RoomId], [Order]) VALUES (N'Machine Door', 6, 20)
				INSERT INTO [dbo].[Puzzle] ([Name], [RoomId], [Order]) VALUES (N'Pickaxe', 5, 1)
				INSERT INTO [dbo].[Puzzle] ([Name], [RoomId], [Order]) VALUES (N'Vase', 5, 2)
				INSERT INTO [dbo].[Puzzle] ([Name], [RoomId], [Order]) VALUES (N'Bomb', 5, 4)
				INSERT INTO [dbo].[Puzzle] ([Name], [RoomId], [Order]) VALUES (N'Tangram', 5, 5)
				INSERT INTO [dbo].[Puzzle] ([Name], [RoomId], [Order]) VALUES (N'Touch Symbols', 5, 6)
				INSERT INTO [dbo].[Puzzle] ([Name], [RoomId], [Order]) VALUES (N'Harp', 5, 7)
				INSERT INTO [dbo].[Puzzle] ([Name], [RoomId], [Order]) VALUES (N'Color Maze', 5, 8)
				INSERT INTO [dbo].[Puzzle] ([Name], [RoomId], [Order]) VALUES (N'Monument Cubes', 5, 9)
				INSERT INTO [dbo].[Puzzle] ([Name], [RoomId], [Order]) VALUES (N'Floor Symbols', 5, 10)
				INSERT INTO [dbo].[Puzzle] ([Name], [RoomId], [Order]) VALUES (N'Stairs', 5, 11)
				INSERT INTO [dbo].[Puzzle] ([Name], [RoomId], [Order]) VALUES (N'Cryptex', 5, 12)
				INSERT INTO [dbo].[Puzzle] ([Name], [RoomId], [Order]) VALUES (N'Levers', 5, 13)
				INSERT INTO [dbo].[Puzzle] ([Name], [RoomId], [Order]) VALUES (N'Crystal + Light Maze', 5, 14)
				INSERT INTO [dbo].[Puzzle] ([Name], [RoomId], [Order]) VALUES (N'Crown + Laser', 5, 16)
				INSERT INTO [dbo].[Puzzle] ([Name], [RoomId], [Order]) VALUES (N'Pyramid', 5, 15)

				");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
