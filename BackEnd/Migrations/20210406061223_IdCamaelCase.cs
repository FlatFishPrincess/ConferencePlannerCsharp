using Microsoft.EntityFrameworkCore.Migrations;

namespace BackEnd.Migrations
{
    public partial class IdCamaelCase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SessionTag_Sessions_SessionID",
                table: "SessionTag");

            migrationBuilder.DropForeignKey(
                name: "FK_SessionTag_Tag_TagID",
                table: "SessionTag");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "Tag",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "TagID",
                table: "SessionTag",
                newName: "TagId");

            migrationBuilder.RenameColumn(
                name: "SessionID",
                table: "SessionTag",
                newName: "SessionId");

            migrationBuilder.RenameIndex(
                name: "IX_SessionTag_TagID",
                table: "SessionTag",
                newName: "IX_SessionTag_TagId");

            migrationBuilder.AddForeignKey(
                name: "FK_SessionTag_Sessions_SessionId",
                table: "SessionTag",
                column: "SessionId",
                principalTable: "Sessions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SessionTag_Tag_TagId",
                table: "SessionTag",
                column: "TagId",
                principalTable: "Tag",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SessionTag_Sessions_SessionId",
                table: "SessionTag");

            migrationBuilder.DropForeignKey(
                name: "FK_SessionTag_Tag_TagId",
                table: "SessionTag");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Tag",
                newName: "ID");

            migrationBuilder.RenameColumn(
                name: "TagId",
                table: "SessionTag",
                newName: "TagID");

            migrationBuilder.RenameColumn(
                name: "SessionId",
                table: "SessionTag",
                newName: "SessionID");

            migrationBuilder.RenameIndex(
                name: "IX_SessionTag_TagId",
                table: "SessionTag",
                newName: "IX_SessionTag_TagID");

            migrationBuilder.AddForeignKey(
                name: "FK_SessionTag_Sessions_SessionID",
                table: "SessionTag",
                column: "SessionID",
                principalTable: "Sessions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SessionTag_Tag_TagID",
                table: "SessionTag",
                column: "TagID",
                principalTable: "Tag",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
