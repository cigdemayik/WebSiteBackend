using Microsoft.EntityFrameworkCore.Migrations;

namespace WebSiteBackend.DataAccess.Migrations
{
    public partial class aa : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Address",
                columns: new[] { "Id", "Content", "Language", "UpdateTime" },
                values: new object[,]
                {
                    { 1, "Test Adres Tr", 1, null },
                    { 2, "Test Adres En", 2, null }
                });

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "Id", "Language", "Name", "UpdateTime" },
                values: new object[,]
                {
                    { 1, 1, "Test Kategori Tr", null },
                    { 2, 2, "Test Kategori En", null }
                });

            migrationBuilder.UpdateData(
                table: "Mission",
                keyColumn: "Id",
                keyValue: 1,
                column: "Content",
                value: "Lorem ipsum dolor sit amet elit. Phasel nec pretium mi. Curabit facilis ornare velit non vulputa. Aliquam metus tortor auctor quis sem. tr");

            migrationBuilder.UpdateData(
                table: "Mission",
                keyColumn: "Id",
                keyValue: 2,
                column: "Content",
                value: "Lorem ipsum dolor sit amet elit. Phasel nec pretium mi. Curabit facilis ornare velit non vulputa. Aliquam metus tortor auctor quis sem. en");

            migrationBuilder.UpdateData(
                table: "Vision",
                keyColumn: "Id",
                keyValue: 1,
                column: "Content",
                value: "Lorem ipsum dolor sit amet elit. Phasel nec pretium mi. Curabit facilis ornare velit non vulputa. Aliquam metus tortor auctor quis sem. tr");

            migrationBuilder.UpdateData(
                table: "Vision",
                keyColumn: "Id",
                keyValue: 2,
                column: "Content",
                value: "Lorem ipsum dolor sit amet elit. Phasel nec pretium mi. Curabit facilis ornare velit non vulputa. Aliquam metus tortor auctor quis sem. en");

            migrationBuilder.InsertData(
                table: "Blog",
                columns: new[] { "Id", "CategoryId", "Content", "Header", "ImageUrl", "Language", "UpdateTime", "UserId" },
                values: new object[,]
                {
                    { 1, 1, "", "Test Blog1", "a", 1, null, 1 },
                    { 2, 1, "", "Test Blog2", "a", 1, null, 1 },
                    { 3, 1, "", "Test Blog3", "a", 1, null, 1 },
                    { 4, 1, "", "Test Blog4", "a", 1, null, 1 },
                    { 5, 1, "", "Test Blog5", "a", 1, null, 1 },
                    { 6, 1, "", "Test Blog6", "a", 1, null, 1 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Address",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Address",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Blog",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Blog",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Blog",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Blog",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Blog",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Blog",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.UpdateData(
                table: "Mission",
                keyColumn: "Id",
                keyValue: 1,
                column: "Content",
                value: "Test Türkçe");

            migrationBuilder.UpdateData(
                table: "Mission",
                keyColumn: "Id",
                keyValue: 2,
                column: "Content",
                value: "Test English");

            migrationBuilder.UpdateData(
                table: "Vision",
                keyColumn: "Id",
                keyValue: 1,
                column: "Content",
                value: "Test Türkçe");

            migrationBuilder.UpdateData(
                table: "Vision",
                keyColumn: "Id",
                keyValue: 2,
                column: "Content",
                value: "Test English");
        }
    }
}
