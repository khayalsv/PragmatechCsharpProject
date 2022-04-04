using Microsoft.EntityFrameworkCore.Migrations;

namespace Relation.Migrations
{
    public partial class dsds : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "TeacherName",
                table: "TEACHER",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "TeacherID",
                table: "TEACHER",
                newName: "ID");

            migrationBuilder.RenameColumn(
                name: "HobbyName",
                table: "HOBBY",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "HobbyID",
                table: "HOBBY",
                newName: "ID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Name",
                table: "TEACHER",
                newName: "TeacherName");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "TEACHER",
                newName: "TeacherID");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "HOBBY",
                newName: "HobbyName");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "HOBBY",
                newName: "HobbyID");
        }
    }
}
