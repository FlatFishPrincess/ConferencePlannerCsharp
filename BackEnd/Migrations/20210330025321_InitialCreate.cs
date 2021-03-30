using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BackEnd.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Session",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EndTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    StartTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Session", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Speaker",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Bio = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WebSite = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Speaker", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "SessionSpeaker",
                columns: table => new
                {
                    SessionsID = table.Column<int>(type: "int", nullable: false),
                    SpeakersID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SessionSpeaker", x => new { x.SessionsID, x.SpeakersID });
                    table.ForeignKey(
                        name: "FK_SessionSpeaker_Session_SessionsID",
                        column: x => x.SessionsID,
                        principalTable: "Session",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SessionSpeaker_Speaker_SpeakersID",
                        column: x => x.SpeakersID,
                        principalTable: "Speaker",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_SessionSpeaker_SpeakersID",
                table: "SessionSpeaker",
                column: "SpeakersID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SessionSpeaker");

            migrationBuilder.DropTable(
                name: "Session");

            migrationBuilder.DropTable(
                name: "Speaker");
        }
    }
}
