using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PanIQ_HintDB.Data.Migrations
{
    public partial class CreateTablesAndSeed : Migration
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

			migrationBuilder.Sql(@"
				
				INSERT INTO [dbo].[Rooms] ([Id], [Name]) VALUES (1, N'Wizard')
				INSERT INTO [dbo].[Rooms] ([Id], [Name]) VALUES (2, N'Casino')
				INSERT INTO [dbo].[Rooms] ([Id], [Name]) VALUES (3, N'Zombie')
				INSERT INTO [dbo].[Rooms] ([Id], [Name]) VALUES (4, N'Haunted')
				INSERT INTO [dbo].[Rooms] ([Id], [Name]) VALUES (5, N'Atlantis')
				INSERT INTO [dbo].[Rooms] ([Id], [Name]) VALUES (6, N'Time Machine')
				INSERT INTO [dbo].[Rooms] ([Id], [Name]) VALUES (7, N'Morning After')


			");

			
			migrationBuilder.Sql(@"
				INSERT INTO [dbo].[Puzzle] ([Name], [RoomId], [Order]) VALUES (N'Close Professor Door', 6, 1)
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

			migrationBuilder.Sql(@"
				INSERT INTO [dbo].[Hint] ([Order], [PuzzleId], [Text]) VALUES (1, 2, N'""EXPLORE THAT BOOKSHELF A BIT MORE""')
				INSERT INTO [dbo].[Hint] ([Order], [PuzzleId], [Text]) VALUES (2, 2, N'PICTURE OF THE SKULL')
				INSERT INTO [dbo].[Hint] ([Order], [PuzzleId], [Text]) VALUES (3, 2, N'""TRY HOLDING THAT BUTTON IN THE SKULL DOWN FOR A MOMENT.""')


			");
		}

        protected override void Down(MigrationBuilder migrationBuilder)
        {
	        migrationBuilder.DropTable(
		        name: "Hint");

	        migrationBuilder.DropTable(
		        name: "Puzzle");

	        migrationBuilder.DropTable(
		        name: "Rooms");
		}
    }
}
