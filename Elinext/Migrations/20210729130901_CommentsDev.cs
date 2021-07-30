using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Elinext.Migrations
{
    public partial class CommentsDev : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Comments",
                columns: new[] { "Id", "CommentId", "CreateDate", "Message", "PostId", "Username" },
                values: new object[] { 1, null, new DateTime(2021, 7, 29, 16, 9, 0, 967, DateTimeKind.Local).AddTicks(1730), "Correct", 1, "KOTKenny" });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2021, 7, 29, 16, 9, 0, 964, DateTimeKind.Local).AddTicks(1899));

            migrationBuilder.InsertData(
                table: "Comments",
                columns: new[] { "Id", "CommentId", "CreateDate", "Message", "PostId", "Username" },
                values: new object[] { 2, 1, new DateTime(2021, 7, 29, 16, 9, 0, 967, DateTimeKind.Local).AddTicks(2331), "Reply", null, "George" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2021, 7, 29, 15, 14, 3, 562, DateTimeKind.Local).AddTicks(3161));
        }
    }
}
