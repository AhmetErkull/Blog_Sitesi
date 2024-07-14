using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Blog_Sitesi.Migrations
{
    /// <inheritdoc />
    public partial class mig5 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ViewCount",
                table: "Posts",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 13, 18, 18, 5, 768, DateTimeKind.Local).AddTicks(4572));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 13, 18, 18, 5, 768, DateTimeKind.Local).AddTicks(4585));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 13, 18, 18, 5, 768, DateTimeKind.Local).AddTicks(4587));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 13, 18, 18, 5, 768, DateTimeKind.Local).AddTicks(4588));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ViewCount" },
                values: new object[] { new DateTime(2024, 7, 13, 18, 18, 5, 769, DateTimeKind.Local).AddTicks(556), 0 });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ViewCount" },
                values: new object[] { new DateTime(2024, 7, 13, 18, 18, 5, 769, DateTimeKind.Local).AddTicks(562), 0 });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 3,
                columns: new[] { "CreatedAt", "ViewCount" },
                values: new object[] { new DateTime(2024, 7, 13, 18, 18, 5, 769, DateTimeKind.Local).AddTicks(564), 0 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 13, 18, 18, 5, 770, DateTimeKind.Local).AddTicks(3290));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 13, 18, 18, 5, 770, DateTimeKind.Local).AddTicks(3301));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 13, 18, 18, 5, 770, DateTimeKind.Local).AddTicks(3303));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 13, 18, 18, 5, 770, DateTimeKind.Local).AddTicks(3304));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 13, 18, 18, 5, 770, DateTimeKind.Local).AddTicks(3306));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 13, 18, 18, 5, 770, DateTimeKind.Local).AddTicks(3309));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 13, 18, 18, 5, 770, DateTimeKind.Local).AddTicks(3310));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 13, 18, 18, 5, 770, DateTimeKind.Local).AddTicks(3311));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 13, 18, 18, 5, 770, DateTimeKind.Local).AddTicks(3313));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 13, 18, 18, 5, 770, DateTimeKind.Local).AddTicks(3315));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ViewCount",
                table: "Posts");

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 13, 11, 24, 38, 591, DateTimeKind.Local).AddTicks(9479));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 13, 11, 24, 38, 591, DateTimeKind.Local).AddTicks(9523));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 13, 11, 24, 38, 591, DateTimeKind.Local).AddTicks(9525));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 13, 11, 24, 38, 591, DateTimeKind.Local).AddTicks(9526));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 13, 11, 24, 38, 592, DateTimeKind.Local).AddTicks(5599));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 13, 11, 24, 38, 592, DateTimeKind.Local).AddTicks(5605));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 13, 11, 24, 38, 592, DateTimeKind.Local).AddTicks(5607));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 13, 11, 24, 38, 593, DateTimeKind.Local).AddTicks(6311));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 13, 11, 24, 38, 593, DateTimeKind.Local).AddTicks(6317));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 13, 11, 24, 38, 593, DateTimeKind.Local).AddTicks(6319));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 13, 11, 24, 38, 593, DateTimeKind.Local).AddTicks(6320));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 13, 11, 24, 38, 593, DateTimeKind.Local).AddTicks(6322));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 13, 11, 24, 38, 593, DateTimeKind.Local).AddTicks(6325));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 13, 11, 24, 38, 593, DateTimeKind.Local).AddTicks(6326));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 13, 11, 24, 38, 593, DateTimeKind.Local).AddTicks(6328));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 13, 11, 24, 38, 593, DateTimeKind.Local).AddTicks(6329));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 13, 11, 24, 38, 593, DateTimeKind.Local).AddTicks(6332));
        }
    }
}
