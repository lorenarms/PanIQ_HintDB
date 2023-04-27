using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PanIQ_HintDB.Data.Migrations
{
    public partial class SeedHauntedZombiePuzzles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
	        migrationBuilder.Sql(@"
			INSERT INTO [dbo].[Puzzle] ([Name], [RoomId], [Order]) VALUES (N'Escape The Rope', 4, 1)
			INSERT INTO [dbo].[Puzzle] ([Name], [RoomId], [Order]) VALUES (N'Symbol Maze', 4, 2)
			INSERT INTO [dbo].[Puzzle] ([Name], [RoomId], [Order]) VALUES (N'Sun, Creepy Clock', 4, 3)
			INSERT INTO [dbo].[Puzzle] ([Name], [RoomId], [Order]) VALUES (N'Rotating Ghost Puzzle', 4, 4)
			INSERT INTO [dbo].[Puzzle] ([Name], [RoomId], [Order]) VALUES (N'Talking Mirror', 4, 5)
			INSERT INTO [dbo].[Puzzle] ([Name], [RoomId], [Order]) VALUES (N'Musical Instruments', 4, 6)
			INSERT INTO [dbo].[Puzzle] ([Name], [RoomId], [Order]) VALUES (N'Change The Object', 4, 7)
			INSERT INTO [dbo].[Puzzle] ([Name], [RoomId], [Order]) VALUES (N'Antique Radio', 4, 8)
			INSERT INTO [dbo].[Puzzle] ([Name], [RoomId], [Order]) VALUES (N'Rotate The Cross', 4, 9)
			INSERT INTO [dbo].[Puzzle] ([Name], [RoomId], [Order]) VALUES (N'Blow The Candle, Terrifying Cabinet', 4, 10)
			INSERT INTO [dbo].[Puzzle] ([Name], [RoomId], [Order]) VALUES (N'Thread Board, Place The Photos', 4, 11)
			INSERT INTO [dbo].[Puzzle] ([Name], [RoomId], [Order]) VALUES (N'Family Portrait', 4, 12)

			INSERT INTO [dbo].[Puzzle] ([Name], [RoomId], [Order]) VALUES (N'Infinity Loop (Horseshoe Tavern Puzzle)', 3, 1)
			INSERT INTO [dbo].[Puzzle] ([Name], [RoomId], [Order]) VALUES (N'Rotating Horseshoes', 3, 2)
			INSERT INTO [dbo].[Puzzle] ([Name], [RoomId], [Order]) VALUES (N'Wagon Wheel', 3, 3)
			INSERT INTO [dbo].[Puzzle] ([Name], [RoomId], [Order]) VALUES (N'Tool Holder', 3, 4)
			INSERT INTO [dbo].[Puzzle] ([Name], [RoomId], [Order]) VALUES (N'Tool Bench Lights', 3, 5)
			INSERT INTO [dbo].[Puzzle] ([Name], [RoomId], [Order]) VALUES (N'Breaker Box', 3, 6)
			INSERT INTO [dbo].[Puzzle] ([Name], [RoomId], [Order]) VALUES (N'Word Decoder', 3, 7)
			INSERT INTO [dbo].[Puzzle] ([Name], [RoomId], [Order]) VALUES (N'Wrench Size', 3, 8)
			INSERT INTO [dbo].[Puzzle] ([Name], [RoomId], [Order]) VALUES (N'License Plates', 3, 9)
			INSERT INTO [dbo].[Puzzle] ([Name], [RoomId], [Order]) VALUES (N'Phone', 3, 10)
			INSERT INTO [dbo].[Puzzle] ([Name], [RoomId], [Order]) VALUES (N'TV', 3, 11)
			INSERT INTO [dbo].[Puzzle] ([Name], [RoomId], [Order]) VALUES (N'Zombie Loops', 3, 12)
			INSERT INTO [dbo].[Puzzle] ([Name], [RoomId], [Order]) VALUES (N'Antidote', 3, 13)
			INSERT INTO [dbo].[Puzzle] ([Name], [RoomId], [Order]) VALUES (N'Bike', 3, 14)

			INSERT INTO [dbo].[Puzzle] ([Name], [RoomId], [Order]) VALUES (N'Venetian Memory Game', 2, 1)
			INSERT INTO [dbo].[Puzzle] ([Name], [RoomId], [Order]) VALUES (N'Alcohol Bottle Weight', 2, 2)
			INSERT INTO [dbo].[Puzzle] ([Name], [RoomId], [Order]) VALUES (N'Lamp Puzzle', 2, 3)
			INSERT INTO [dbo].[Puzzle] ([Name], [RoomId], [Order]) VALUES (N'4 Clocks Puzzle', 2, 4)
			INSERT INTO [dbo].[Puzzle] ([Name], [RoomId], [Order]) VALUES (N'Painting Piece Puzzle', 2, 5)
			INSERT INTO [dbo].[Puzzle] ([Name], [RoomId], [Order]) VALUES (N'Moon Push Panel', 2, 6)
			INSERT INTO [dbo].[Puzzle] ([Name], [RoomId], [Order]) VALUES (N'Statues & Bookshelf', 2, 7)
			INSERT INTO [dbo].[Puzzle] ([Name], [RoomId], [Order]) VALUES (N'Buzzwire', 2, 8)
			INSERT INTO [dbo].[Puzzle] ([Name], [RoomId], [Order]) VALUES (N'Blasting The Door', 2, 10)
			INSERT INTO [dbo].[Puzzle] ([Name], [RoomId], [Order]) VALUES (N'Vault Drawers', 2, 11)
			INSERT INTO [dbo].[Puzzle] ([Name], [RoomId], [Order]) VALUES (N'Attendance Register & Security Camera Footage', 2, 12)

			INSERT INTO [dbo].[Puzzle] ([Name], [RoomId], [Order]) VALUES (N'Table Hand Maze', 1, 1)
			INSERT INTO [dbo].[Puzzle] ([Name], [RoomId], [Order]) VALUES (N'Knocking Chest', 1, 2)
			INSERT INTO [dbo].[Puzzle] ([Name], [RoomId], [Order]) VALUES (N'Sit In Chair & Magic Book', 1, 3)
			INSERT INTO [dbo].[Puzzle] ([Name], [RoomId], [Order]) VALUES (N'Potion Smelling & Spell Chart', 1, 4)
			INSERT INTO [dbo].[Puzzle] ([Name], [RoomId], [Order]) VALUES (N'Spirits Board & Keypad', 1, 5)
			INSERT INTO [dbo].[Puzzle] ([Name], [RoomId], [Order]) VALUES (N'Stone Pieces', 1, 6)
			INSERT INTO [dbo].[Puzzle] ([Name], [RoomId], [Order]) VALUES (N'Mirror & Fireplace', 1, 7)
			INSERT INTO [dbo].[Puzzle] ([Name], [RoomId], [Order]) VALUES (N'Owl', 1, 8)
			INSERT INTO [dbo].[Puzzle] ([Name], [RoomId], [Order]) VALUES (N'Spinning Globe & Podium', 1, 9)
			INSERT INTO [dbo].[Puzzle] ([Name], [RoomId], [Order]) VALUES (N'Planets', 1, 10)
			INSERT INTO [dbo].[Puzzle] ([Name], [RoomId], [Order]) VALUES (N'Magic Ball & Wooden Staves', 1, 11)
			INSERT INTO [dbo].[Puzzle] ([Name], [RoomId], [Order]) VALUES (N'Wizard Shelf', 1, 12)
			INSERT INTO [dbo].[Puzzle] ([Name], [RoomId], [Order]) VALUES (N'Potion Pot', 1, 13)

			INSERT INTO [dbo].[Puzzle] ([Name], [RoomId], [Order]) VALUES (N'Venetian Memory Game', 7, 1)
			INSERT INTO [dbo].[Puzzle] ([Name], [RoomId], [Order]) VALUES (N'Coke Puzzle', 7, 2)
			INSERT INTO [dbo].[Puzzle] ([Name], [RoomId], [Order]) VALUES (N'Lamp Puzzle', 7, 3)
			INSERT INTO [dbo].[Puzzle] ([Name], [RoomId], [Order]) VALUES (N'Clocks', 7, 4)
			INSERT INTO [dbo].[Puzzle] ([Name], [RoomId], [Order]) VALUES (N'Moon Push Panel', 7, 5)
			INSERT INTO [dbo].[Puzzle] ([Name], [RoomId], [Order]) VALUES (N'Dildo Shape', 7, 6)
			INSERT INTO [dbo].[Puzzle] ([Name], [RoomId], [Order]) VALUES (N'Statues & Bookshelf', 7, 7)
			INSERT INTO [dbo].[Puzzle] ([Name], [RoomId], [Order]) VALUES (N'Buzzwire', 7, 8)
			INSERT INTO [dbo].[Puzzle] ([Name], [RoomId], [Order]) VALUES (N'Door Blast', 7, 10)
			INSERT INTO [dbo].[Puzzle] ([Name], [RoomId], [Order]) VALUES (N'Drawers', 7, 11)

			");

	        
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
