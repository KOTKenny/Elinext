using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Elinext.Migrations
{
    public partial class PostModelEdited : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "CreateDate",
                table: "Post",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Title",
                table: "Post",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "Post",
                columns: new[] { "Id", "Article", "CreateDate", "Title" },
                values: new object[] { 1, "This is new post", new DateTime(2021, 7, 29, 15, 12, 53, 253, DateTimeKind.Local).AddTicks(5584), null });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DropColumn(
                name: "CreateDate",
                table: "Post");

            migrationBuilder.DropColumn(
                name: "Title",
                table: "Post");
        }
    }
}
