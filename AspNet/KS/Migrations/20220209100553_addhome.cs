using Microsoft.EntityFrameworkCore.Migrations;

namespace KS.Migrations
{
    public partial class addhome : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Tag1",
                table: "HomePageMs",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Tag2",
                table: "HomePageMs",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Tag3",
                table: "HomePageMs",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Tag1",
                table: "HomePageMs");

            migrationBuilder.DropColumn(
                name: "Tag2",
                table: "HomePageMs");

            migrationBuilder.DropColumn(
                name: "Tag3",
                table: "HomePageMs");
        }
    }
}
