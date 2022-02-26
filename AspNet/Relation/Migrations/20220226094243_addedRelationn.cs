using Microsoft.EntityFrameworkCore.Migrations;

namespace Relation.Migrations
{
    public partial class addedRelationn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_STUDENT_GROUP_AddressID",
                table: "STUDENT");

            migrationBuilder.DropPrimaryKey(
                name: "PK_GROUP",
                table: "GROUP");

            migrationBuilder.RenameTable(
                name: "GROUP",
                newName: "ADDRESS");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ADDRESS",
                table: "ADDRESS",
                column: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_STUDENT_ADDRESS_AddressID",
                table: "STUDENT",
                column: "AddressID",
                principalTable: "ADDRESS",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_STUDENT_ADDRESS_AddressID",
                table: "STUDENT");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ADDRESS",
                table: "ADDRESS");

            migrationBuilder.RenameTable(
                name: "ADDRESS",
                newName: "GROUP");

            migrationBuilder.AddPrimaryKey(
                name: "PK_GROUP",
                table: "GROUP",
                column: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_STUDENT_GROUP_AddressID",
                table: "STUDENT",
                column: "AddressID",
                principalTable: "GROUP",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
