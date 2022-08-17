using Microsoft.EntityFrameworkCore.Migrations;

namespace Nasarna.Migrations
{
    public partial class AmountPercentColumnTypeChanged : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "AmountPercent",
                table: "Causes",
                type: "decimal(18, 6)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18, 2)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "AmountPercent",
                table: "Causes",
                type: "decimal(18, 2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18, 6)");
        }
    }
}
