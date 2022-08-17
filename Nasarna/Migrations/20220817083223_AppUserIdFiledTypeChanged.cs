using Microsoft.EntityFrameworkCore.Migrations;

namespace Nasarna.Migrations
{
    public partial class AppUserIdFiledTypeChanged : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CauseComments_AspNetUsers_AppUserId1",
                table: "CauseComments");

            migrationBuilder.DropIndex(
                name: "IX_CauseComments_AppUserId1",
                table: "CauseComments");

            migrationBuilder.DropColumn(
                name: "AppUserId1",
                table: "CauseComments");

            migrationBuilder.AlterColumn<string>(
                name: "AppUserId",
                table: "CauseComments",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.CreateIndex(
                name: "IX_CauseComments_AppUserId",
                table: "CauseComments",
                column: "AppUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_CauseComments_AspNetUsers_AppUserId",
                table: "CauseComments",
                column: "AppUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CauseComments_AspNetUsers_AppUserId",
                table: "CauseComments");

            migrationBuilder.DropIndex(
                name: "IX_CauseComments_AppUserId",
                table: "CauseComments");

            migrationBuilder.AlterColumn<int>(
                name: "AppUserId",
                table: "CauseComments",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AppUserId1",
                table: "CauseComments",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_CauseComments_AppUserId1",
                table: "CauseComments",
                column: "AppUserId1");

            migrationBuilder.AddForeignKey(
                name: "FK_CauseComments_AspNetUsers_AppUserId1",
                table: "CauseComments",
                column: "AppUserId1",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
