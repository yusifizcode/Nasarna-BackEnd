using Microsoft.EntityFrameworkCore.Migrations;

namespace Nasarna.Migrations
{
    public partial class ChangesAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BlogComments_AspNetUsers_AppUserId1",
                table: "BlogComments");

            migrationBuilder.DropIndex(
                name: "IX_BlogComments_AppUserId1",
                table: "BlogComments");

            migrationBuilder.DropColumn(
                name: "AppUserId1",
                table: "BlogComments");

            migrationBuilder.AlterColumn<string>(
                name: "AppUserId",
                table: "BlogComments",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.CreateIndex(
                name: "IX_BlogComments_AppUserId",
                table: "BlogComments",
                column: "AppUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_BlogComments_AspNetUsers_AppUserId",
                table: "BlogComments",
                column: "AppUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BlogComments_AspNetUsers_AppUserId",
                table: "BlogComments");

            migrationBuilder.DropIndex(
                name: "IX_BlogComments_AppUserId",
                table: "BlogComments");

            migrationBuilder.AlterColumn<int>(
                name: "AppUserId",
                table: "BlogComments",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AppUserId1",
                table: "BlogComments",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_BlogComments_AppUserId1",
                table: "BlogComments",
                column: "AppUserId1");

            migrationBuilder.AddForeignKey(
                name: "FK_BlogComments_AspNetUsers_AppUserId1",
                table: "BlogComments",
                column: "AppUserId1",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
