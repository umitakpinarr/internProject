using Microsoft.EntityFrameworkCore.Migrations;

namespace JobsArgeya.Migrations
{
    public partial class InitialCreate4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "adress",
                table: "Settings");

            migrationBuilder.DropColumn(
                name: "description",
                table: "Settings");

            migrationBuilder.DropColumn(
                name: "email",
                table: "Settings");

            migrationBuilder.DropColumn(
                name: "facebook",
                table: "Settings");

            migrationBuilder.DropColumn(
                name: "instagram",
                table: "Settings");

            migrationBuilder.DropColumn(
                name: "keywords",
                table: "Settings");

            migrationBuilder.DropColumn(
                name: "linkedin",
                table: "Settings");

            migrationBuilder.DropColumn(
                name: "logo",
                table: "Settings");

            migrationBuilder.DropColumn(
                name: "phone",
                table: "Settings");

            migrationBuilder.DropColumn(
                name: "smtpPassword",
                table: "Settings");

            migrationBuilder.DropColumn(
                name: "smtpPort",
                table: "Settings");

            migrationBuilder.DropColumn(
                name: "smtpServer",
                table: "Settings");

            migrationBuilder.DropColumn(
                name: "smtpUserName",
                table: "Settings");

            migrationBuilder.RenameColumn(
                name: "twitter",
                table: "Settings",
                newName: "value");

            migrationBuilder.RenameColumn(
                name: "title",
                table: "Settings",
                newName: "key");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "value",
                table: "Settings",
                newName: "twitter");

            migrationBuilder.RenameColumn(
                name: "key",
                table: "Settings",
                newName: "title");

            migrationBuilder.AddColumn<string>(
                name: "adress",
                table: "Settings",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "description",
                table: "Settings",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "email",
                table: "Settings",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "facebook",
                table: "Settings",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "instagram",
                table: "Settings",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "keywords",
                table: "Settings",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "linkedin",
                table: "Settings",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "logo",
                table: "Settings",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "phone",
                table: "Settings",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "smtpPassword",
                table: "Settings",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "smtpPort",
                table: "Settings",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "smtpServer",
                table: "Settings",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "smtpUserName",
                table: "Settings",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
