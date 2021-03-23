using Microsoft.EntityFrameworkCore.Migrations;

namespace WebSiteBackend.DataAccess.Concrete.EFCore.Migrations
{
    public partial class defaultAdmin : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "Password", "UpdateTime", "UserName" },
                values: new object[] { 1, "123456", null, "admin" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
