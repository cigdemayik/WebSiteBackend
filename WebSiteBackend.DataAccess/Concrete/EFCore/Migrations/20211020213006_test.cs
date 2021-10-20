using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebSiteBackend.DataAccess.Concrete.EFCore.Migrations
{
    public partial class test : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "UserName",
                table: "User",
                newName: "Username");

            migrationBuilder.RenameColumn(
                name: "Deleted",
                table: "User",
                newName: "Active");

            migrationBuilder.RenameColumn(
                name: "Deleted",
                table: "Product",
                newName: "Active");

            migrationBuilder.RenameColumn(
                name: "Deleted",
                table: "Category",
                newName: "Active");

            migrationBuilder.RenameColumn(
                name: "Deleted",
                table: "Carousel",
                newName: "Active");

            migrationBuilder.RenameColumn(
                name: "ReleaseTime",
                table: "Blog",
                newName: "PublishStartDate");

            migrationBuilder.RenameColumn(
                name: "Deleted",
                table: "Blog",
                newName: "Active");

            migrationBuilder.AddColumn<int>(
                name: "Language",
                table: "User",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "ImageUrl",
                table: "Product",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Language",
                table: "Product",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Language",
                table: "Category",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Language",
                table: "Carousel",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "PublishEndDate",
                table: "Carousel",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "PublishStartDate",
                table: "Carousel",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "Language",
                table: "Blog",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "PublishEndDate",
                table: "Blog",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Language",
                table: "User");

            migrationBuilder.DropColumn(
                name: "ImageUrl",
                table: "Product");

            migrationBuilder.DropColumn(
                name: "Language",
                table: "Product");

            migrationBuilder.DropColumn(
                name: "Language",
                table: "Category");

            migrationBuilder.DropColumn(
                name: "Language",
                table: "Carousel");

            migrationBuilder.DropColumn(
                name: "PublishEndDate",
                table: "Carousel");

            migrationBuilder.DropColumn(
                name: "PublishStartDate",
                table: "Carousel");

            migrationBuilder.DropColumn(
                name: "Language",
                table: "Blog");

            migrationBuilder.DropColumn(
                name: "PublishEndDate",
                table: "Blog");

            migrationBuilder.RenameColumn(
                name: "Username",
                table: "User",
                newName: "UserName");

            migrationBuilder.RenameColumn(
                name: "Active",
                table: "User",
                newName: "Deleted");

            migrationBuilder.RenameColumn(
                name: "Active",
                table: "Product",
                newName: "Deleted");

            migrationBuilder.RenameColumn(
                name: "Active",
                table: "Category",
                newName: "Deleted");

            migrationBuilder.RenameColumn(
                name: "Active",
                table: "Carousel",
                newName: "Deleted");

            migrationBuilder.RenameColumn(
                name: "PublishStartDate",
                table: "Blog",
                newName: "ReleaseTime");

            migrationBuilder.RenameColumn(
                name: "Active",
                table: "Blog",
                newName: "Deleted");
        }
    }
}
