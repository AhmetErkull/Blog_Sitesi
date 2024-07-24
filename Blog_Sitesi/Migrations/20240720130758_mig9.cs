using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Blog_Sitesi.Migrations
{
    /// <inheritdoc />
    public partial class mig9 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddUniqueConstraint(
                name: "AK_Posts_Title",
                table: "Posts",
                column: "Title");

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 20, 16, 7, 57, 327, DateTimeKind.Local).AddTicks(2365));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 20, 16, 7, 57, 327, DateTimeKind.Local).AddTicks(2379));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 20, 16, 7, 57, 327, DateTimeKind.Local).AddTicks(2381));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 20, 16, 7, 57, 327, DateTimeKind.Local).AddTicks(2383));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 20, 16, 7, 57, 327, DateTimeKind.Local).AddTicks(9920));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 20, 16, 7, 57, 327, DateTimeKind.Local).AddTicks(9928));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 20, 16, 7, 57, 327, DateTimeKind.Local).AddTicks(9931));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 20, 16, 7, 57, 327, DateTimeKind.Local).AddTicks(9934));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 20, 16, 7, 57, 327, DateTimeKind.Local).AddTicks(9936));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 20, 16, 7, 57, 327, DateTimeKind.Local).AddTicks(9940));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 20, 16, 7, 57, 327, DateTimeKind.Local).AddTicks(9942));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 20, 16, 7, 57, 327, DateTimeKind.Local).AddTicks(9945));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 20, 16, 7, 57, 327, DateTimeKind.Local).AddTicks(9947));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 20, 16, 7, 57, 327, DateTimeKind.Local).AddTicks(9950));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 20, 16, 7, 57, 327, DateTimeKind.Local).AddTicks(9952));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 20, 16, 7, 57, 327, DateTimeKind.Local).AddTicks(9954));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 20, 16, 7, 57, 327, DateTimeKind.Local).AddTicks(9957));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 20, 16, 7, 57, 327, DateTimeKind.Local).AddTicks(9959));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 20, 16, 7, 57, 327, DateTimeKind.Local).AddTicks(9961));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 20, 16, 7, 57, 327, DateTimeKind.Local).AddTicks(9963));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 20, 16, 7, 57, 327, DateTimeKind.Local).AddTicks(9965));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 20, 16, 7, 57, 327, DateTimeKind.Local).AddTicks(9968));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 20, 16, 7, 57, 329, DateTimeKind.Local).AddTicks(1624));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 20, 16, 7, 57, 329, DateTimeKind.Local).AddTicks(1643));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 20, 16, 7, 57, 329, DateTimeKind.Local).AddTicks(1645));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 20, 16, 7, 57, 329, DateTimeKind.Local).AddTicks(1650));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 20, 16, 7, 57, 329, DateTimeKind.Local).AddTicks(1653));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 20, 16, 7, 57, 329, DateTimeKind.Local).AddTicks(1658));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 20, 16, 7, 57, 329, DateTimeKind.Local).AddTicks(1660));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 20, 16, 7, 57, 329, DateTimeKind.Local).AddTicks(1662));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 20, 16, 7, 57, 329, DateTimeKind.Local).AddTicks(1664));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 20, 16, 7, 57, 329, DateTimeKind.Local).AddTicks(1667));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropUniqueConstraint(
                name: "AK_Posts_Title",
                table: "Posts");

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 13, 20, 45, 0, 774, DateTimeKind.Local).AddTicks(1688));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 13, 20, 45, 0, 774, DateTimeKind.Local).AddTicks(1702));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 13, 20, 45, 0, 774, DateTimeKind.Local).AddTicks(1704));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 13, 20, 45, 0, 774, DateTimeKind.Local).AddTicks(1705));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 13, 20, 45, 0, 774, DateTimeKind.Local).AddTicks(8390));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 13, 20, 45, 0, 774, DateTimeKind.Local).AddTicks(8466));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 13, 20, 45, 0, 774, DateTimeKind.Local).AddTicks(8468));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 13, 20, 45, 0, 774, DateTimeKind.Local).AddTicks(8470));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 13, 20, 45, 0, 774, DateTimeKind.Local).AddTicks(8471));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 13, 20, 45, 0, 774, DateTimeKind.Local).AddTicks(8474));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 13, 20, 45, 0, 774, DateTimeKind.Local).AddTicks(8475));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 13, 20, 45, 0, 774, DateTimeKind.Local).AddTicks(8477));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 13, 20, 45, 0, 774, DateTimeKind.Local).AddTicks(8478));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 13, 20, 45, 0, 774, DateTimeKind.Local).AddTicks(8481));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 13, 20, 45, 0, 774, DateTimeKind.Local).AddTicks(8482));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 13, 20, 45, 0, 774, DateTimeKind.Local).AddTicks(8483));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 13, 20, 45, 0, 774, DateTimeKind.Local).AddTicks(8485));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 13, 20, 45, 0, 774, DateTimeKind.Local).AddTicks(8486));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 13, 20, 45, 0, 774, DateTimeKind.Local).AddTicks(8487));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 13, 20, 45, 0, 774, DateTimeKind.Local).AddTicks(8488));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 13, 20, 45, 0, 774, DateTimeKind.Local).AddTicks(8490));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 13, 20, 45, 0, 774, DateTimeKind.Local).AddTicks(8492));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 13, 20, 45, 0, 781, DateTimeKind.Local).AddTicks(2259));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 13, 20, 45, 0, 781, DateTimeKind.Local).AddTicks(2273));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 13, 20, 45, 0, 781, DateTimeKind.Local).AddTicks(2275));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 13, 20, 45, 0, 781, DateTimeKind.Local).AddTicks(2276));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 13, 20, 45, 0, 781, DateTimeKind.Local).AddTicks(2278));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 13, 20, 45, 0, 781, DateTimeKind.Local).AddTicks(2282));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 13, 20, 45, 0, 781, DateTimeKind.Local).AddTicks(2283));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 13, 20, 45, 0, 781, DateTimeKind.Local).AddTicks(2284));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 13, 20, 45, 0, 781, DateTimeKind.Local).AddTicks(2285));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 13, 20, 45, 0, 781, DateTimeKind.Local).AddTicks(2288));
        }
    }
}
