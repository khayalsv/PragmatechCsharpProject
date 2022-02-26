using Microsoft.EntityFrameworkCore.Migrations;

namespace Relation.Migrations
{
    public partial class addedRelation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_STUDENT_GROUP_StudentID",
                table: "STUDENT");

            migrationBuilder.DropColumn(
                name: "Image",
                table: "STUDENT");

            migrationBuilder.DropColumn(
                name: "Scor",
                table: "STUDENT");

            migrationBuilder.RenameColumn(
                name: "StudentID",
                table: "STUDENT",
                newName: "AddressID");

            migrationBuilder.RenameIndex(
                name: "IX_STUDENT_StudentID",
                table: "STUDENT",
                newName: "IX_STUDENT_AddressID");

            migrationBuilder.AddForeignKey(
                name: "FK_STUDENT_GROUP_AddressID",
                table: "STUDENT",
                column: "AddressID",
                principalTable: "GROUP",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_STUDENT_GROUP_AddressID",
                table: "STUDENT");

            migrationBuilder.RenameColumn(
                name: "AddressID",
                table: "STUDENT",
                newName: "StudentID");

            migrationBuilder.RenameIndex(
                name: "IX_STUDENT_AddressID",
                table: "STUDENT",
                newName: "IX_STUDENT_StudentID");

            migrationBuilder.AddColumn<string>(
                name: "Image",
                table: "STUDENT",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Scor",
                table: "STUDENT",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_STUDENT_GROUP_StudentID",
                table: "STUDENT",
                column: "StudentID",
                principalTable: "GROUP",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
