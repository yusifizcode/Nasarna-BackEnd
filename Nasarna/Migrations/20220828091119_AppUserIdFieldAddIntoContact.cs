using Microsoft.EntityFrameworkCore.Migrations;

namespace Nasarna.Migrations
{
    public partial class AppUserIdFieldAddIntoContact : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "AppUserId",
                table: "Contacts",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Contacts_AppUserId",
                table: "Contacts",
                column: "AppUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Contacts_AspNetUsers_AppUserId",
                table: "Contacts",
                column: "AppUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Contacts_AspNetUsers_AppUserId",
                table: "Contacts");

            migrationBuilder.DropIndex(
                name: "IX_Contacts_AppUserId",
                table: "Contacts");

            migrationBuilder.DropColumn(
                name: "AppUserId",
                table: "Contacts");
        }
    }
}
