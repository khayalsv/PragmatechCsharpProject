using Microsoft.EntityFrameworkCore.Migrations;

namespace Relation.Migrations
{
    public partial class addedrell : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Scor",
                table: "STUDENT",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Scor",
                table: "STUDENT");
        }
    }
}
