using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BackEnd.Migrations
{
    public partial class UpdatedEntities : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SessionSpeaker_Session_SessionsID",
                table: "SessionSpeaker");

            migrationBuilder.DropForeignKey(
                name: "FK_SessionSpeaker_Speaker_SpeakersID",
                table: "SessionSpeaker");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Speaker",
                table: "Speaker");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Session",
                table: "Session");

            migrationBuilder.RenameTable(
                name: "Speaker",
                newName: "Speakers");

            migrationBuilder.RenameTable(
                name: "Session",
                newName: "Sessions");

            migrationBuilder.RenameColumn(
                name: "SpeakersID",
                table: "SessionSpeaker",
                newName: "SpeakerID");

            migrationBuilder.RenameColumn(
                name: "SessionsID",
                table: "SessionSpeaker",
                newName: "SessionID");

            migrationBuilder.RenameIndex(
                name: "IX_SessionSpeaker_SpeakersID",
                table: "SessionSpeaker",
                newName: "IX_SessionSpeaker_SpeakerID");

            migrationBuilder.AlterColumn<string>(
                name: "WebSite",
                table: "Speakers",
                type: "nvarchar(1000)",
                maxLength: 1000,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Speakers",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Bio",
                table: "Speakers",
                type: "nvarchar(4000)",
                maxLength: 4000,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "StartTime",
                table: "Sessions",
                type: "datetimeoffset",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "EndTime",
                table: "Sessions",
                type: "datetimeoffset",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AddColumn<string>(
                name: "Abstract",
                table: "Sessions",
                type: "nvarchar(4000)",
                maxLength: 4000,
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ConferenceID",
                table: "Sessions",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TrackID",
                table: "Sessions",
                type: "int",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Speakers",
                table: "Speakers",
                column: "ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Sessions",
                table: "Sessions",
                column: "ID");

            migrationBuilder.CreateTable(
                name: "Tracks",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tracks", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Sessions_TrackID",
                table: "Sessions",
                column: "TrackID");

            migrationBuilder.AddForeignKey(
                name: "FK_Sessions_Tracks_TrackID",
                table: "Sessions",
                column: "TrackID",
                principalTable: "Tracks",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_SessionSpeaker_Sessions_SessionID",
                table: "SessionSpeaker",
                column: "SessionID",
                principalTable: "Sessions",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SessionSpeaker_Speakers_SpeakerID",
                table: "SessionSpeaker",
                column: "SpeakerID",
                principalTable: "Speakers",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Sessions_Tracks_TrackID",
                table: "Sessions");

            migrationBuilder.DropForeignKey(
                name: "FK_SessionSpeaker_Sessions_SessionID",
                table: "SessionSpeaker");

            migrationBuilder.DropForeignKey(
                name: "FK_SessionSpeaker_Speakers_SpeakerID",
                table: "SessionSpeaker");

            migrationBuilder.DropTable(
                name: "Tracks");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Speakers",
                table: "Speakers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Sessions",
                table: "Sessions");

            migrationBuilder.DropIndex(
                name: "IX_Sessions_TrackID",
                table: "Sessions");

            migrationBuilder.DropColumn(
                name: "Abstract",
                table: "Sessions");

            migrationBuilder.DropColumn(
                name: "ConferenceID",
                table: "Sessions");

            migrationBuilder.DropColumn(
                name: "TrackID",
                table: "Sessions");

            migrationBuilder.RenameTable(
                name: "Speakers",
                newName: "Speaker");

            migrationBuilder.RenameTable(
                name: "Sessions",
                newName: "Session");

            migrationBuilder.RenameColumn(
                name: "SpeakerID",
                table: "SessionSpeaker",
                newName: "SpeakersID");

            migrationBuilder.RenameColumn(
                name: "SessionID",
                table: "SessionSpeaker",
                newName: "SessionsID");

            migrationBuilder.RenameIndex(
                name: "IX_SessionSpeaker_SpeakerID",
                table: "SessionSpeaker",
                newName: "IX_SessionSpeaker_SpeakersID");

            migrationBuilder.AlterColumn<string>(
                name: "WebSite",
                table: "Speaker",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(1000)",
                oldMaxLength: 1000,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Speaker",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200);

            migrationBuilder.AlterColumn<string>(
                name: "Bio",
                table: "Speaker",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(4000)",
                oldMaxLength: 4000);

            migrationBuilder.AlterColumn<DateTime>(
                name: "StartTime",
                table: "Session",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "EndTime",
                table: "Session",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Speaker",
                table: "Speaker",
                column: "ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Session",
                table: "Session",
                column: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_SessionSpeaker_Session_SessionsID",
                table: "SessionSpeaker",
                column: "SessionsID",
                principalTable: "Session",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SessionSpeaker_Speaker_SpeakersID",
                table: "SessionSpeaker",
                column: "SpeakersID",
                principalTable: "Speaker",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
