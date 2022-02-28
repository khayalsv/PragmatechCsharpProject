using Microsoft.EntityFrameworkCore.Migrations;

namespace Relation.Migrations
{
    public partial class addmany : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "HOBBY",
                columns: table => new
                {
                    HobbyID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HobbyName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HOBBY", x => x.HobbyID);
                });

            migrationBuilder.CreateTable(
                name: "TEACHER",
                columns: table => new
                {
                    TeacherID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TeacherName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TEACHER", x => x.TeacherID);
                });

            migrationBuilder.CreateTable(
                name: "TEACHERTOHOBBY",
                columns: table => new
                {
                    TeacherID = table.Column<int>(type: "int", nullable: false),
                    HobbyID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TEACHERTOHOBBY", x => new { x.TeacherID, x.HobbyID });
                    table.ForeignKey(
                        name: "FK_TEACHERTOHOBBY_HOBBY_HobbyID",
                        column: x => x.HobbyID,
                        principalTable: "HOBBY",
                        principalColumn: "HobbyID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TEACHERTOHOBBY_TEACHER_TeacherID",
                        column: x => x.TeacherID,
                        principalTable: "TEACHER",
                        principalColumn: "TeacherID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TEACHERTOHOBBY_HobbyID",
                table: "TEACHERTOHOBBY",
                column: "HobbyID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TEACHERTOHOBBY");

            migrationBuilder.DropTable(
                name: "HOBBY");

            migrationBuilder.DropTable(
                name: "TEACHER");
        }
    }
}
