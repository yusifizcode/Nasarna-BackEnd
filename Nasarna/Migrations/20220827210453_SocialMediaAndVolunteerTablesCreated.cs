using Microsoft.EntityFrameworkCore.Migrations;

namespace Nasarna.Migrations
{
    public partial class SocialMediaAndVolunteerTablesCreated : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsVolunteer",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Volunteer",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AppUserId = table.Column<string>(nullable: true),
                    Subject = table.Column<string>(maxLength: 50, nullable: true),
                    Description = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Volunteer", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Volunteer_AspNetUsers_AppUserId",
                        column: x => x.AppUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "UserSocialMedia",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VolunteerId = table.Column<int>(nullable: false),
                    FacebookUrl = table.Column<string>(nullable: true),
                    TwitterUrl = table.Column<string>(nullable: true),
                    EmailUrl = table.Column<string>(nullable: true),
                    InstagramUrl = table.Column<string>(nullable: true),
                    AppUserId = table.Column<string>(nullable: true)
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

            migrationBuilder.CreateIndex(
                name: "IX_Volunteer_AppUserId",
                table: "Volunteer",
                column: "AppUserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UserSocialMedia");

            migrationBuilder.DropTable(
                name: "Volunteer");

            migrationBuilder.DropColumn(
                name: "IsVolunteer",
                table: "AspNetUsers");
        }
    }
}
