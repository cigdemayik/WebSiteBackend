using Microsoft.EntityFrameworkCore.Migrations;

namespace WebSiteBackend.DataAccess.Migrations
{
    public partial class aboutus : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AboutUs",
                keyColumn: "Id",
                keyValue: 1,
                column: "ImageUrl",
                value: "a");

            migrationBuilder.UpdateData(
                table: "AboutUs",
                keyColumn: "Id",
                keyValue: 2,
                column: "ImageUrl",
                value: "a");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AboutUs",
                keyColumn: "Id",
                keyValue: 1,
                column: "ImageUrl",
                value: "../img/kunefe1.jpg");

            migrationBuilder.UpdateData(
                table: "AboutUs",
                keyColumn: "Id",
                keyValue: 2,
                column: "ImageUrl",
                value: "../img/kunefe1.jpg");
        }
    }
}
