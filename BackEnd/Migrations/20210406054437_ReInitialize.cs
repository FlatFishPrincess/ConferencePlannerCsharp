using Microsoft.EntityFrameworkCore.Migrations;

namespace BackEnd.Migrations
{
    public partial class ReInitialize : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SessionAttendee_Attendee_AttendeeID",
                table: "SessionAttendee");

            migrationBuilder.DropForeignKey(
                name: "FK_SessionAttendee_Sessions_SessionID",
                table: "SessionAttendee");

            migrationBuilder.DropForeignKey(
                name: "FK_Sessions_Tracks_TrackID",
                table: "Sessions");

            migrationBuilder.DropForeignKey(
                name: "FK_SessionSpeaker_Sessions_SessionID",
                table: "SessionSpeaker");

            migrationBuilder.DropForeignKey(
                name: "FK_SessionSpeaker_Speakers_SpeakerID",
                table: "SessionSpeaker");

            migrationBuilder.DropColumn(
                name: "ConferenceID",
                table: "Sessions");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "Tracks",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "Speakers",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "SpeakerID",
                table: "SessionSpeaker",
                newName: "SpeakerId");

            migrationBuilder.RenameColumn(
                name: "SessionID",
                table: "SessionSpeaker",
                newName: "SessionId");

            migrationBuilder.RenameIndex(
                name: "IX_SessionSpeaker_SpeakerID",
                table: "SessionSpeaker",
                newName: "IX_SessionSpeaker_SpeakerId");

            migrationBuilder.RenameColumn(
                name: "TrackID",
                table: "Sessions",
                newName: "TrackId");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "Sessions",
                newName: "Id");

            migrationBuilder.RenameIndex(
                name: "IX_Sessions_TrackID",
                table: "Sessions",
                newName: "IX_Sessions_TrackId");

            migrationBuilder.RenameColumn(
                name: "AttendeeID",
                table: "SessionAttendee",
                newName: "AttendeeId");

            migrationBuilder.RenameColumn(
                name: "SessionID",
                table: "SessionAttendee",
                newName: "SessionId");

            migrationBuilder.RenameIndex(
                name: "IX_SessionAttendee_AttendeeID",
                table: "SessionAttendee",
                newName: "IX_SessionAttendee_AttendeeId");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "Attendee",
                newName: "Id");

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "Sessions",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "UserName",
                table: "Attendee",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(256)",
                oldMaxLength: 256,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "EmailAddress",
                table: "Attendee",
                type: "nvarchar(256)",
                maxLength: 256,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_SessionAttendee_Attendee_AttendeeId",
                table: "SessionAttendee",
                column: "AttendeeId",
                principalTable: "Attendee",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SessionAttendee_Sessions_SessionId",
                table: "SessionAttendee",
                column: "SessionId",
                principalTable: "Sessions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Sessions_Tracks_TrackId",
                table: "Sessions",
                column: "TrackId",
                principalTable: "Tracks",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_SessionSpeaker_Sessions_SessionId",
                table: "SessionSpeaker",
                column: "SessionId",
                principalTable: "Sessions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SessionSpeaker_Speakers_SpeakerId",
                table: "SessionSpeaker",
                column: "SpeakerId",
                principalTable: "Speakers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SessionAttendee_Attendee_AttendeeId",
                table: "SessionAttendee");

            migrationBuilder.DropForeignKey(
                name: "FK_SessionAttendee_Sessions_SessionId",
                table: "SessionAttendee");

            migrationBuilder.DropForeignKey(
                name: "FK_Sessions_Tracks_TrackId",
                table: "Sessions");

            migrationBuilder.DropForeignKey(
                name: "FK_SessionSpeaker_Sessions_SessionId",
                table: "SessionSpeaker");

            migrationBuilder.DropForeignKey(
                name: "FK_SessionSpeaker_Speakers_SpeakerId",
                table: "SessionSpeaker");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Tracks",
                newName: "ID");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Speakers",
                newName: "ID");

            migrationBuilder.RenameColumn(
                name: "SpeakerId",
                table: "SessionSpeaker",
                newName: "SpeakerID");

            migrationBuilder.RenameColumn(
                name: "SessionId",
                table: "SessionSpeaker",
                newName: "SessionID");

            migrationBuilder.RenameIndex(
                name: "IX_SessionSpeaker_SpeakerId",
                table: "SessionSpeaker",
                newName: "IX_SessionSpeaker_SpeakerID");

            migrationBuilder.RenameColumn(
                name: "TrackId",
                table: "Sessions",
                newName: "TrackID");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Sessions",
                newName: "ID");

            migrationBuilder.RenameIndex(
                name: "IX_Sessions_TrackId",
                table: "Sessions",
                newName: "IX_Sessions_TrackID");

            migrationBuilder.RenameColumn(
                name: "AttendeeId",
                table: "SessionAttendee",
                newName: "AttendeeID");

            migrationBuilder.RenameColumn(
                name: "SessionId",
                table: "SessionAttendee",
                newName: "SessionID");

            migrationBuilder.RenameIndex(
                name: "IX_SessionAttendee_AttendeeId",
                table: "SessionAttendee",
                newName: "IX_SessionAttendee_AttendeeID");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Attendee",
                newName: "ID");

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "Sessions",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200);

            migrationBuilder.AddColumn<int>(
                name: "ConferenceID",
                table: "Sessions",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "UserName",
                table: "Attendee",
                type: "nvarchar(256)",
                maxLength: 256,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200);

            migrationBuilder.AlterColumn<string>(
                name: "EmailAddress",
                table: "Attendee",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(256)",
                oldMaxLength: 256,
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_SessionAttendee_Attendee_AttendeeID",
                table: "SessionAttendee",
                column: "AttendeeID",
                principalTable: "Attendee",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SessionAttendee_Sessions_SessionID",
                table: "SessionAttendee",
                column: "SessionID",
                principalTable: "Sessions",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Sessions_Tracks_TrackID",
                table: "Sessions",
                column: "TrackID",
                principalTable: "Tracks",
                principalColumn: "ID",
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
    }
}
