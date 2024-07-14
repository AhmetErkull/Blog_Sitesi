using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Blog_Sitesi.Migrations
{
    /// <inheritdoc />
    public partial class mig4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Images",
                columns: table => new
                {
                    ImageId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PostId = table.Column<int>(type: "int", nullable: false),
                    Url = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Images", x => x.ImageId);
                    table.ForeignKey(
                        name: "FK_Images_Posts_PostId",
                        column: x => x.PostId,
                        principalTable: "Posts",
                        principalColumn: "PostId",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.InsertData(
                table: "Images",
                columns: new[] { "ImageId", "PostId", "Url" },
                values: new object[,]
                {
                    { 1, 1, "https://letsenhance.io/static/8f5e523ee6b2479e26ecc91b9c25261e/1015f/MainAfter.jpg" },
                    { 2, 1, "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTuWXzkIYkMaVY24lJLPWFRS3WKI3kB3Ls0bg&s" },
                    { 3, 2, "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcREoRGyXmHy_6aIgXYqWHdOT3KjfmnuSyxypw&s" }
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_Images_PostId",
                table: "Images",
                column: "PostId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Images");

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 12, 20, 44, 4, 251, DateTimeKind.Local).AddTicks(7335));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 12, 20, 44, 4, 251, DateTimeKind.Local).AddTicks(7349));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 12, 20, 44, 4, 251, DateTimeKind.Local).AddTicks(7350));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 12, 20, 44, 4, 251, DateTimeKind.Local).AddTicks(7352));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 12, 20, 44, 4, 252, DateTimeKind.Local).AddTicks(1220));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 12, 20, 44, 4, 252, DateTimeKind.Local).AddTicks(1225));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 12, 20, 44, 4, 252, DateTimeKind.Local).AddTicks(1227));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 12, 20, 44, 4, 253, DateTimeKind.Local).AddTicks(2000));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 12, 20, 44, 4, 253, DateTimeKind.Local).AddTicks(2008));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 12, 20, 44, 4, 253, DateTimeKind.Local).AddTicks(2010));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 12, 20, 44, 4, 253, DateTimeKind.Local).AddTicks(2011));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 12, 20, 44, 4, 253, DateTimeKind.Local).AddTicks(2012));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 12, 20, 44, 4, 253, DateTimeKind.Local).AddTicks(2016));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 12, 20, 44, 4, 253, DateTimeKind.Local).AddTicks(2017));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 12, 20, 44, 4, 253, DateTimeKind.Local).AddTicks(2019));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 12, 20, 44, 4, 253, DateTimeKind.Local).AddTicks(2020));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 12, 20, 44, 4, 253, DateTimeKind.Local).AddTicks(2022));
        }
    }
}
