using Microsoft.EntityFrameworkCore.Migrations;

namespace Relation.Migrations
{
    public partial class addedRelat : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_STUDENT_ADDRESS_AddressID",
                table: "STUDENT");

            migrationBuilder.DropIndex(
                name: "IX_STUDENT_AddressID",
                table: "STUDENT");

            migrationBuilder.DropColumn(
                name: "AddressID",
                table: "STUDENT");

            migrationBuilder.AddColumn<int>(
                name: "StudentID",
                table: "ADDRESS",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_ADDRESS_StudentID",
                table: "ADDRESS",
                column: "StudentID",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_ADDRESS_STUDENT_StudentID",
                table: "ADDRESS",
                column: "StudentID",
                principalTable: "STUDENT",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ADDRESS_STUDENT_StudentID",
                table: "ADDRESS");

            migrationBuilder.DropIndex(
                name: "IX_ADDRESS_StudentID",
                table: "ADDRESS");

            migrationBuilder.DropColumn(
                name: "StudentID",
                table: "ADDRESS");

            migrationBuilder.AddColumn<int>(
                name: "AddressID",
                table: "STUDENT",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_STUDENT_AddressID",
                table: "STUDENT",
                column: "AddressID",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_STUDENT_ADDRESS_AddressID",
                table: "STUDENT",
                column: "AddressID",
                principalTable: "ADDRESS",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
