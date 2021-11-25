using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebSiteBackend.DataAccess.Concrete.EfCore.Migrations
{
    public partial class localization : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "LocalizationResource",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Key = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Language = table.Column<int>(type: "int", nullable: false),
                    CreateTime = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "getdate()"),
                    UpdateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Active = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LocalizationResource", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "LocalizationResource",
                columns: new[] { "Id", "Key", "Language", "UpdateTime", "Value" },
                values: new object[] { 1, "TestBaslik", 1, null, "English Header" });

            migrationBuilder.InsertData(
                table: "LocalizationResource",
                columns: new[] { "Id", "Key", "Language", "UpdateTime", "Value" },
                values: new object[] { 2, "TestBaslik", 2, null, "Türkçe Başlık" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LocalizationResource");
        }
    }
}
