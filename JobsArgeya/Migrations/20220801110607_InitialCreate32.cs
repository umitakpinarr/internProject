using Microsoft.EntityFrameworkCore.Migrations;

namespace JobsArgeya.Migrations
{
    public partial class InitialCreate32 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "IsDocsDone",
                table: "Applies",
                type: "int",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsDocsDone",
                table: "Applies");
        }
    }
}
