using Microsoft.EntityFrameworkCore.Migrations;

namespace Nasarna.Migrations
{
    public partial class AppUserIdFieldAddToCauses : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "AppUserId1",
                table: "Causes",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Causes_AppUserId1",
                table: "Causes",
                column: "AppUserId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Causes_AspNetUsers_AppUserId1",
                table: "Causes",
                column: "AppUserId1",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Causes_AspNetUsers_AppUserId1",
                table: "Causes");

            migrationBuilder.DropIndex(
                name: "IX_Causes_AppUserId1",
                table: "Causes");

            migrationBuilder.DropColumn(
                name: "AppUserId1",
                table: "Causes");
        }
    }
}
