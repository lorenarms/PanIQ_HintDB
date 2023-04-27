using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PanIQ_HintDB.Data.Migrations
{
    public partial class ChangeHintEntryDBToLogEntry : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "NewHintEntry");

            migrationBuilder.CreateTable(
                name: "LogEntry",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomText = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Glitch = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Bypass = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    DateAdded = table.Column<DateTime>(type: "datetime2", nullable: false),
                    HintId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LogEntry", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LogEntry_Hint_HintId",
                        column: x => x.HintId,
                        principalTable: "Hint",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_LogEntry_HintId",
                table: "LogEntry",
                column: "HintId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LogEntry");

            migrationBuilder.CreateTable(
                name: "NewHintEntry",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HintId = table.Column<int>(type: "int", nullable: false),
                    Bypass = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    CustomText = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    DateAdded = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Glitch = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true)
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
    }
}
