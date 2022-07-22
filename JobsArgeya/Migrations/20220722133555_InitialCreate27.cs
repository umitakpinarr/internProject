using Microsoft.EntityFrameworkCore.Migrations;

namespace JobsArgeya.Migrations
{
    public partial class InitialCreate27 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Logo1",
                table: "Settings",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Logo1",
                table: "Settings");
        }
    }
}
