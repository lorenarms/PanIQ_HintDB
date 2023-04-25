using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PanIQ_HintDB.Data.Migrations
{
    public partial class CreateNewHintEntryDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "NewHintEntry",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HintId = table.Column<int>(type: "int", nullable: false),
                    CustomText = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Glitch = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Bypass = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    DateAdded = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NewHintEntry", x => x.Id);
                    table.ForeignKey(
                        name: "FK_NewHintEntry_Hint_HintId",
                        column: x => x.HintId,
                        principalTable: "Hint",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_NewHintEntry_HintId",
                table: "NewHintEntry",
                column: "HintId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "NewHintEntry");

        }
    }
}
