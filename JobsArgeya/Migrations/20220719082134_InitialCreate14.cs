using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace JobsArgeya.Migrations
{
    public partial class InitialCreate14 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "internEndDate",
                table: "Applies",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "internStartDate",
                table: "Applies",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "isIntern",
                table: "Applies",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "internEndDate",
                table: "Applies");

            migrationBuilder.DropColumn(
                name: "internStartDate",
                table: "Applies");

            migrationBuilder.DropColumn(
                name: "isIntern",
                table: "Applies");
        }
    }
}
