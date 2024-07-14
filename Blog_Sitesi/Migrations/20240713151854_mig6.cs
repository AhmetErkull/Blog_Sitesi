using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Blog_Sitesi.Migrations
{
    /// <inheritdoc />
    public partial class mig6 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "ViewCount",
                table: "Posts",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 13, 18, 18, 54, 273, DateTimeKind.Local).AddTicks(73));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 13, 18, 18, 54, 273, DateTimeKind.Local).AddTicks(86));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 13, 18, 18, 54, 273, DateTimeKind.Local).AddTicks(88));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 13, 18, 18, 54, 273, DateTimeKind.Local).AddTicks(89));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 13, 18, 18, 54, 273, DateTimeKind.Local).AddTicks(6248));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 13, 18, 18, 54, 273, DateTimeKind.Local).AddTicks(6394));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 13, 18, 18, 54, 273, DateTimeKind.Local).AddTicks(6395));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 13, 18, 18, 54, 274, DateTimeKind.Local).AddTicks(6949));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 13, 18, 18, 54, 274, DateTimeKind.Local).AddTicks(6959));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 13, 18, 18, 54, 274, DateTimeKind.Local).AddTicks(6961));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 13, 18, 18, 54, 274, DateTimeKind.Local).AddTicks(6962));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 13, 18, 18, 54, 274, DateTimeKind.Local).AddTicks(6963));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 13, 18, 18, 54, 274, DateTimeKind.Local).AddTicks(7003));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 13, 18, 18, 54, 274, DateTimeKind.Local).AddTicks(7004));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 13, 18, 18, 54, 274, DateTimeKind.Local).AddTicks(7005));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 13, 18, 18, 54, 274, DateTimeKind.Local).AddTicks(7007));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 13, 18, 18, 54, 274, DateTimeKind.Local).AddTicks(7009));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "ViewCount",
                table: "Posts",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldDefaultValue: 0);

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
                column: "CreatedAt",
                value: new DateTime(2024, 7, 13, 18, 18, 5, 769, DateTimeKind.Local).AddTicks(556));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 13, 18, 18, 5, 769, DateTimeKind.Local).AddTicks(562));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 13, 18, 18, 5, 769, DateTimeKind.Local).AddTicks(564));

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
    }
}
