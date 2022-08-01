using Microsoft.EntityFrameworkCore.Migrations;

namespace JobsArgeya.Migrations
{
    public partial class InitialCreate33 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "IsHired",
                table: "Applies",
                type: "int",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsHired",
                table: "Applies");
        }
    }
}
