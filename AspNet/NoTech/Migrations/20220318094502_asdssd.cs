using Microsoft.EntityFrameworkCore.Migrations;

namespace NoTech.Migrations
{
    public partial class asdssd : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "SocialLink",
                table: "Layouts",
                newName: "SocialLink4");

            migrationBuilder.RenameColumn(
                name: "SocialIcon",
                table: "Layouts",
                newName: "SocialLink3");

            migrationBuilder.AlterColumn<string>(
                name: "BoxText",
                table: "ProjectAbouts",
                type: "nvarchar(25)",
                maxLength: 25,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SocialIcon1",
                table: "Layouts",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SocialIcon2",
                table: "Layouts",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SocialIcon3",
                table: "Layouts",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SocialIcon4",
                table: "Layouts",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SocialLink1",
                table: "Layouts",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SocialLink2",
                table: "Layouts",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SocialIcon1",
                table: "Layouts");

            migrationBuilder.DropColumn(
                name: "SocialIcon2",
                table: "Layouts");

            migrationBuilder.DropColumn(
                name: "SocialIcon3",
                table: "Layouts");

            migrationBuilder.DropColumn(
                name: "SocialIcon4",
                table: "Layouts");

            migrationBuilder.DropColumn(
                name: "SocialLink1",
                table: "Layouts");

            migrationBuilder.DropColumn(
                name: "SocialLink2",
                table: "Layouts");

            migrationBuilder.RenameColumn(
                name: "SocialLink4",
                table: "Layouts",
                newName: "SocialLink");

            migrationBuilder.RenameColumn(
                name: "SocialLink3",
                table: "Layouts",
                newName: "SocialIcon");

            migrationBuilder.AlterColumn<string>(
                name: "BoxText",
                table: "ProjectAbouts",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(25)",
                oldMaxLength: 25,
                oldNullable: true);
        }
    }
}
