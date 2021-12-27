using Microsoft.EntityFrameworkCore.Migrations;

namespace WebSiteBackend.DataAccess.Concrete.EfCore.Migrations
{
    public partial class last : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "LocalizationResource",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Key", "Value" },
                values: new object[] { "VisionMission", "Vision & Mission" });

            migrationBuilder.UpdateData(
                table: "LocalizationResource",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Key", "Value" },
                values: new object[] { "VisionMission", "Vizyon & Misyon" });

            migrationBuilder.InsertData(
                table: "LocalizationResource",
                columns: new[] { "Id", "Key", "Language", "UpdateTime", "Value" },
                values: new object[,]
                {
                    { 37, "Reserved", 1, null, "Reserved" },
                    { 23, "LastBlog", 1, null, "Last Blog" },
                    { 24, "LastBlog", 2, null, "Son Yayınlanan Blog" },
                    { 25, "LastBlogs", 1, null, "Last Blogs" },
                    { 26, "LastBlogs", 2, null, "Son Yayınlanann Bloglar" },
                    { 27, "More", 1, null, "Show More" },
                    { 28, "More", 2, null, "Daha Fazla..." },
                    { 38, "Reserved", 2, null, "Tarafından Saklıdır." },
                    { 29, "Home", 1, null, "Home" },
                    { 31, "Blog", 1, null, "Blog" },
                    { 32, "Blog", 2, null, "Blog" },
                    { 33, "Admin", 1, null, "Admin" },
                    { 34, "Admin", 2, null, "Admin" },
                    { 35, "AllRights", 1, null, "All Rights By" },
                    { 36, "AllRights", 2, null, "Tüm Hakları" },
                    { 22, "Follow", 2, null, "Takip Et" },
                    { 30, "Home", 2, null, "Anasayfa" },
                    { 21, "Follow", 1, null, "Follow Us" },
                    { 19, "EMail", 1, null, "E-Mail" },
                    { 4, "Vision", 2, null, "Vizyon" },
                    { 5, "Mission", 1, null, "Mission" },
                    { 6, "Mission", 2, null, "Misyon" },
                    { 7, "Blogs", 1, null, "Blogs" },
                    { 8, "Blogs", 2, null, "Bloglar" },
                    { 9, "AboutUs", 1, null, "About Us" },
                    { 10, "AboutUs", 2, null, "Hakkımızda" },
                    { 11, "Contact", 1, null, "Contact" },
                    { 12, "Contact", 2, null, "İletişim" },
                    { 13, "ContactUs", 1, null, "ContactUs" },
                    { 14, "ContactUs", 2, null, "İletişime Geçin" },
                    { 15, "Address", 1, null, "Address" },
                    { 16, "Address", 2, null, "Adres" },
                    { 17, "Phone", 1, null, "Phone" },
                    { 18, "Phone", 2, null, "Telefon" },
                    { 20, "EMail", 2, null, "E-Posta" },
                    { 3, "Vision", 1, null, "Vision" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "LocalizationResource",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "LocalizationResource",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "LocalizationResource",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "LocalizationResource",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "LocalizationResource",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "LocalizationResource",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "LocalizationResource",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "LocalizationResource",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "LocalizationResource",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "LocalizationResource",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "LocalizationResource",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "LocalizationResource",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "LocalizationResource",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "LocalizationResource",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "LocalizationResource",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "LocalizationResource",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "LocalizationResource",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "LocalizationResource",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "LocalizationResource",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "LocalizationResource",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "LocalizationResource",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "LocalizationResource",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "LocalizationResource",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "LocalizationResource",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "LocalizationResource",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "LocalizationResource",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "LocalizationResource",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "LocalizationResource",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "LocalizationResource",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "LocalizationResource",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "LocalizationResource",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "LocalizationResource",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "LocalizationResource",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "LocalizationResource",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "LocalizationResource",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "LocalizationResource",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.UpdateData(
                table: "LocalizationResource",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Key", "Value" },
                values: new object[] { "TestBaslik", "English Header" });

            migrationBuilder.UpdateData(
                table: "LocalizationResource",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Key", "Value" },
                values: new object[] { "TestBaslik", "Türkçe Başlık" });
        }
    }
}
