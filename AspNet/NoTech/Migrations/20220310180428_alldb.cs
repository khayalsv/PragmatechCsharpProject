using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace NoTech.Migrations
{
    public partial class alldb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Abouts",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(35)", maxLength: 35, nullable: true),
                    Text = table.Column<string>(type: "nvarchar(70)", maxLength: 70, nullable: true),
                    List = table.Column<string>(type: "nvarchar(35)", maxLength: 35, nullable: true),
                    Subheading = table.Column<string>(type: "nvarchar(35)", maxLength: 35, nullable: true),
                    Image1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Image2 = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Abouts", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Blogs",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    DateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    byFrom = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    Name = table.Column<string>(type: "nvarchar(80)", maxLength: 80, nullable: true),
                    Link = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Blogs", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Counters",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Odometer = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    Title = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    Text = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    Icon = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Counters", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Helpings",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Text = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Icon = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SubTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SubText = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Helpings", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Layouts",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SocialLink = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SocialIcon = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Question = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Phone = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Layouts", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "ProjectAbouts",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Text = table.Column<string>(type: "nvarchar(70)", maxLength: 70, nullable: true),
                    BoxText = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    List1 = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    List2 = table.Column<string>(type: "nvarchar(35)", maxLength: 35, nullable: true),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProjectAbouts", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "ProjectBoxes",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TopTitle = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    BoxTitle = table.Column<string>(type: "nvarchar(45)", maxLength: 45, nullable: true),
                    Name1 = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    Name2 = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    Link = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProjectBoxes", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "ServicesBoxes",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title1 = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Title2 = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Text1 = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    Text2 = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    Icon = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ServicesBoxes", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "ServicesTitles",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Text = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SubTitle1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SubTitle2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ServicesTitles", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Testimonials",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Text = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    Name = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    Company = table.Column<string>(type: "nvarchar(45)", maxLength: 45, nullable: true),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Testimonials", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Abouts");

            migrationBuilder.DropTable(
                name: "Blogs");

            migrationBuilder.DropTable(
                name: "Counters");

            migrationBuilder.DropTable(
                name: "Helpings");

            migrationBuilder.DropTable(
                name: "Layouts");

            migrationBuilder.DropTable(
                name: "ProjectAbouts");

            migrationBuilder.DropTable(
                name: "ProjectBoxes");

            migrationBuilder.DropTable(
                name: "ServicesBoxes");

            migrationBuilder.DropTable(
                name: "ServicesTitles");

            migrationBuilder.DropTable(
                name: "Testimonials");
        }
    }
}
