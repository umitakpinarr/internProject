using Microsoft.EntityFrameworkCore.Migrations;

namespace JobsArgeya.Migrations
{
    public partial class InitialCreate28 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Logo1",
                table: "Settings",
                newName: "DarkLogo");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "DarkLogo",
                table: "Settings",
                newName: "Logo1");
        }
    }
}
