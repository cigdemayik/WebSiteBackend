using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebSiteBackend.DataAccess.Concrete.EFCore.Migrations
{
    public partial class z : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Language",
                table: "User");

            migrationBuilder.CreateTable(
                name: "AboutUs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Language = table.Column<int>(type: "int", nullable: false),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreateTime = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GetDate()"),
                    UpdateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Active = table.Column<bool>(type: "bit", nullable: false, defaultValue: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AboutUs", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "AboutUs",
                columns: new[] { "Id", "Active", "Content", "Language", "UpdateTime" },
                values: new object[] { 1, true, "Test Türkçe", 1, null });

            migrationBuilder.InsertData(
                table: "AboutUs",
                columns: new[] { "Id", "Active", "Content", "Language", "UpdateTime" },
                values: new object[] { 2, true, "Test English", 2, null });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AboutUs");

            migrationBuilder.AddColumn<int>(
                name: "Language",
                table: "User",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
