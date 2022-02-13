using Microsoft.EntityFrameworkCore.Migrations;

namespace KS.Migrations
{
    public partial class addresume : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Resumes",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    edtitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    eddetail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    eddescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    extitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    exdetail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    exdescription = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Resumes", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Resumes");
        }
    }
}
