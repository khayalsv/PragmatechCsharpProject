using Microsoft.EntityFrameworkCore.Migrations;

namespace SampleTemplate.Migrations
{
    public partial class addeddata : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Sliders",
                columns: new[] { "ID", "ClothType", "DisCount", "Image", "Price", "TrendWord" },
                values: new object[] { 1, "On Jackets", "Get up to 60% off", "slide1.jpg", 130, "Winter Fashion Trends" });

            migrationBuilder.InsertData(
                table: "Sliders",
                columns: new[] { "ID", "ClothType", "DisCount", "Image", "Price", "TrendWord" },
                values: new object[] { 2, "On Coat", "Get up to 10% off", "slide2.jpg", 200, "Season Fashion Trends" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Sliders",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Sliders",
                keyColumn: "ID",
                keyValue: 2);
        }
    }
}
