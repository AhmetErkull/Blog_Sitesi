using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Blog_Sitesi.Migrations
{
    /// <inheritdoc />
    public partial class mig10 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Role",
                table: "Users")
                .Annotation("SqlServer:IsTemporal", true)
                .Annotation("SqlServer:TemporalHistoryTableName", "UsersHistory")
                .Annotation("SqlServer:TemporalHistoryTableSchema", null)
                .Annotation("SqlServer:TemporalPeriodEndColumnName", "PeriodEnd")
                .Annotation("SqlServer:TemporalPeriodStartColumnName", "PeriodStart");

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 23, 9, 17, 49, 127, DateTimeKind.Local).AddTicks(7345));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 23, 9, 17, 49, 127, DateTimeKind.Local).AddTicks(7356));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 23, 9, 17, 49, 127, DateTimeKind.Local).AddTicks(7358));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 23, 9, 17, 49, 127, DateTimeKind.Local).AddTicks(7359));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 23, 9, 17, 49, 128, DateTimeKind.Local).AddTicks(4168));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 23, 9, 17, 49, 128, DateTimeKind.Local).AddTicks(4174));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 23, 9, 17, 49, 128, DateTimeKind.Local).AddTicks(4176));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 23, 9, 17, 49, 128, DateTimeKind.Local).AddTicks(4178));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 23, 9, 17, 49, 128, DateTimeKind.Local).AddTicks(4180));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 23, 9, 17, 49, 128, DateTimeKind.Local).AddTicks(4183));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 23, 9, 17, 49, 128, DateTimeKind.Local).AddTicks(4185));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 23, 9, 17, 49, 128, DateTimeKind.Local).AddTicks(4186));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 23, 9, 17, 49, 128, DateTimeKind.Local).AddTicks(4217));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 23, 9, 17, 49, 128, DateTimeKind.Local).AddTicks(4219));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 23, 9, 17, 49, 128, DateTimeKind.Local).AddTicks(4221));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 23, 9, 17, 49, 128, DateTimeKind.Local).AddTicks(4223));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 23, 9, 17, 49, 128, DateTimeKind.Local).AddTicks(4224));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 23, 9, 17, 49, 128, DateTimeKind.Local).AddTicks(4226));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 23, 9, 17, 49, 128, DateTimeKind.Local).AddTicks(4228));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 23, 9, 17, 49, 128, DateTimeKind.Local).AddTicks(4229));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 23, 9, 17, 49, 128, DateTimeKind.Local).AddTicks(4232));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 23, 9, 17, 49, 128, DateTimeKind.Local).AddTicks(4234));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 23, 9, 17, 49, 129, DateTimeKind.Local).AddTicks(4472));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 23, 9, 17, 49, 129, DateTimeKind.Local).AddTicks(4479));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 23, 9, 17, 49, 129, DateTimeKind.Local).AddTicks(4481));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 23, 9, 17, 49, 129, DateTimeKind.Local).AddTicks(4482));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 23, 9, 17, 49, 129, DateTimeKind.Local).AddTicks(4483));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 23, 9, 17, 49, 129, DateTimeKind.Local).AddTicks(4487));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 23, 9, 17, 49, 129, DateTimeKind.Local).AddTicks(4488));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 23, 9, 17, 49, 129, DateTimeKind.Local).AddTicks(4489));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 23, 9, 17, 49, 129, DateTimeKind.Local).AddTicks(4490));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 23, 9, 17, 49, 129, DateTimeKind.Local).AddTicks(4492));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Role",
                table: "Users",
                type: "nvarchar(6)",
                maxLength: 6,
                nullable: false,
                defaultValue: "")
                .Annotation("SqlServer:IsTemporal", true)
                .Annotation("SqlServer:TemporalHistoryTableName", "UsersHistory")
                .Annotation("SqlServer:TemporalHistoryTableSchema", null)
                .Annotation("SqlServer:TemporalPeriodEndColumnName", "PeriodEnd")
                .Annotation("SqlServer:TemporalPeriodStartColumnName", "PeriodStart");

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
                columns: new[] { "CreatedAt", "Role" },
                values: new object[] { new DateTime(2024, 7, 20, 16, 7, 57, 329, DateTimeKind.Local).AddTicks(1624), "admin" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 2,
                columns: new[] { "CreatedAt", "Role" },
                values: new object[] { new DateTime(2024, 7, 20, 16, 7, 57, 329, DateTimeKind.Local).AddTicks(1643), "user" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 3,
                columns: new[] { "CreatedAt", "Role" },
                values: new object[] { new DateTime(2024, 7, 20, 16, 7, 57, 329, DateTimeKind.Local).AddTicks(1645), "user" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 4,
                columns: new[] { "CreatedAt", "Role" },
                values: new object[] { new DateTime(2024, 7, 20, 16, 7, 57, 329, DateTimeKind.Local).AddTicks(1650), "user" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 5,
                columns: new[] { "CreatedAt", "Role" },
                values: new object[] { new DateTime(2024, 7, 20, 16, 7, 57, 329, DateTimeKind.Local).AddTicks(1653), "user" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 6,
                columns: new[] { "CreatedAt", "Role" },
                values: new object[] { new DateTime(2024, 7, 20, 16, 7, 57, 329, DateTimeKind.Local).AddTicks(1658), "user" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 7,
                columns: new[] { "CreatedAt", "Role" },
                values: new object[] { new DateTime(2024, 7, 20, 16, 7, 57, 329, DateTimeKind.Local).AddTicks(1660), "user" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 8,
                columns: new[] { "CreatedAt", "Role" },
                values: new object[] { new DateTime(2024, 7, 20, 16, 7, 57, 329, DateTimeKind.Local).AddTicks(1662), "user" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 9,
                columns: new[] { "CreatedAt", "Role" },
                values: new object[] { new DateTime(2024, 7, 20, 16, 7, 57, 329, DateTimeKind.Local).AddTicks(1664), "user" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 10,
                columns: new[] { "CreatedAt", "Role" },
                values: new object[] { new DateTime(2024, 7, 20, 16, 7, 57, 329, DateTimeKind.Local).AddTicks(1667), "user" });
        }
    }
}
