using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Elinext.Migrations
{
    public partial class CommentsInt : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "Message" },
                values: new object[] { new DateTime(2021, 7, 29, 22, 2, 27, 914, DateTimeKind.Local).AddTicks(9068), "Comment" });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2021, 7, 29, 22, 2, 27, 914, DateTimeKind.Local).AddTicks(9657));

            migrationBuilder.InsertData(
                table: "Comments",
                columns: new[] { "Id", "CommentId", "CreateDate", "Message", "PostId", "Username" },
                values: new object[,]
                {
                    { 3, 2, new DateTime(2021, 7, 29, 22, 2, 27, 915, DateTimeKind.Local).AddTicks(195), "ReplyOfReply", null, "Daly" },
                    { 5, null, new DateTime(2021, 7, 29, 22, 2, 27, 915, DateTimeKind.Local).AddTicks(217), "Comment", 1, "Oleg" }
                });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2021, 7, 29, 22, 2, 27, 911, DateTimeKind.Local).AddTicks(3181));

            migrationBuilder.InsertData(
                table: "Comments",
                columns: new[] { "Id", "CommentId", "CreateDate", "Message", "PostId", "Username" },
                values: new object[] { 4, 3, new DateTime(2021, 7, 29, 22, 2, 27, 915, DateTimeKind.Local).AddTicks(215), "ReplyOfReplyOfRely", null, "Minsy" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "Message" },
                values: new object[] { new DateTime(2021, 7, 29, 17, 13, 19, 840, DateTimeKind.Local).AddTicks(6109), "Correct" });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2021, 7, 29, 17, 13, 19, 840, DateTimeKind.Local).AddTicks(7545));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2021, 7, 29, 17, 13, 19, 836, DateTimeKind.Local).AddTicks(2885));
        }
    }
}
