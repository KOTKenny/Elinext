using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Elinext.Migrations
{
    public partial class PostInitData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "Title" },
                values: new object[] { new DateTime(2021, 7, 29, 15, 14, 3, 562, DateTimeKind.Local).AddTicks(3161), "This is Title of Post" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "Title" },
                values: new object[] { new DateTime(2021, 7, 29, 15, 12, 53, 253, DateTimeKind.Local).AddTicks(5584), null });
        }
    }
}
