using Microsoft.EntityFrameworkCore.Migrations;

namespace Nasarna.Migrations
{
    public partial class VolunteersTablesAddtoDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Volunteer_AspNetUsers_AppUserId",
                table: "Volunteer");

            migrationBuilder.DropTable(
                name: "UserSocialMedia");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Volunteer",
                table: "Volunteer");

            migrationBuilder.RenameTable(
                name: "Volunteer",
                newName: "Volunteers");

            migrationBuilder.RenameIndex(
                name: "IX_Volunteer_AppUserId",
                table: "Volunteers",
                newName: "IX_Volunteers_AppUserId");

            migrationBuilder.AddColumn<string>(
                name: "FacebookUrl",
                table: "Volunteers",
                maxLength: 100,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "InstagramUrl",
                table: "Volunteers",
                maxLength: 100,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TwitterUrl",
                table: "Volunteers",
                maxLength: 100,
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Volunteers",
                table: "Volunteers",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Volunteers_AspNetUsers_AppUserId",
                table: "Volunteers",
                column: "AppUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Volunteers_AspNetUsers_AppUserId",
                table: "Volunteers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Volunteers",
                table: "Volunteers");

            migrationBuilder.DropColumn(
                name: "FacebookUrl",
                table: "Volunteers");

            migrationBuilder.DropColumn(
                name: "InstagramUrl",
                table: "Volunteers");

            migrationBuilder.DropColumn(
                name: "TwitterUrl",
                table: "Volunteers");

            migrationBuilder.RenameTable(
                name: "Volunteers",
                newName: "Volunteer");

            migrationBuilder.RenameIndex(
                name: "IX_Volunteers_AppUserId",
                table: "Volunteer",
                newName: "IX_Volunteer_AppUserId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Volunteer",
                table: "Volunteer",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "UserSocialMedia",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AppUserId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    EmailUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FacebookUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InstagramUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TwitterUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VolunteerId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserSocialMedia", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserSocialMedia_AspNetUsers_AppUserId",
                        column: x => x.AppUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_UserSocialMedia_Volunteer_VolunteerId",
                        column: x => x.VolunteerId,
                        principalTable: "Volunteer",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_UserSocialMedia_AppUserId",
                table: "UserSocialMedia",
                column: "AppUserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserSocialMedia_VolunteerId",
                table: "UserSocialMedia",
                column: "VolunteerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Volunteer_AspNetUsers_AppUserId",
                table: "Volunteer",
                column: "AppUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
