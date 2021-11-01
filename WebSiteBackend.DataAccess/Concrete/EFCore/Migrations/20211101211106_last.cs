using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebSiteBackend.DataAccess.Concrete.EFCore.Migrations
{
    public partial class last : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "VissionMission");

            migrationBuilder.DropColumn(
                name: "Adress",
                table: "AboutUs");

            migrationBuilder.CreateTable(
                name: "Address",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Language = table.Column<int>(type: "int", nullable: false),
                    CreateTime = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GetDate()"),
                    UpdateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Active = table.Column<bool>(type: "bit", nullable: false, defaultValue: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Address", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Mission",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Language = table.Column<int>(type: "int", nullable: false),
                    CreateTime = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GetDate()"),
                    UpdateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Active = table.Column<bool>(type: "bit", nullable: false, defaultValue: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mission", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Vission",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Language = table.Column<int>(type: "int", nullable: false),
                    CreateTime = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GetDate()"),
                    UpdateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Active = table.Column<bool>(type: "bit", nullable: false, defaultValue: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vission", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Mission",
                columns: new[] { "Id", "Active", "Content", "Language", "UpdateTime" },
                values: new object[,]
                {
                    { 1, true, "Test Türkçe", 1, null },
                    { 2, true, "Test English", 2, null }
                });

            migrationBuilder.InsertData(
                table: "Vission",
                columns: new[] { "Id", "Active", "Content", "Language", "UpdateTime" },
                values: new object[,]
                {
                    { 1, true, "Test Türkçe", 1, null },
                    { 2, true, "Test English", 2, null }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Address");

            migrationBuilder.DropTable(
                name: "Mission");

            migrationBuilder.DropTable(
                name: "Vission");

            migrationBuilder.AddColumn<string>(
                name: "Adress",
                table: "AboutUs",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "VissionMission",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Active = table.Column<bool>(type: "bit", nullable: false, defaultValue: true),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreateTime = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GetDate()"),
                    Language = table.Column<int>(type: "int", nullable: false),
                    UpdateTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VissionMission", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "AboutUs",
                keyColumn: "Id",
                keyValue: 1,
                column: "Adress",
                value: "Gaziantep");

            migrationBuilder.UpdateData(
                table: "AboutUs",
                keyColumn: "Id",
                keyValue: 2,
                column: "Adress",
                value: "İstanbul");
        }
    }
}
