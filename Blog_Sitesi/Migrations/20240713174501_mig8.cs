using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Blog_Sitesi.Migrations
{
    /// <inheritdoc />
    public partial class mig8 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.InsertData(
                table: "Images",
                columns: new[] { "ImageId", "PostId", "Url" },
                values: new object[,]
                {
                    { 4, 3, "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTlJ2u482NBtw501OOICaZxGrIcxNtG5SuqWQ&s" },
                    { 5, 4, "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSxlT_-PpQJbt3DsWOZDQYohRy4YF8ck1n8PA&s" },
                    { 6, 5, "https://plus.unsplash.com/premium_photo-1676637000058-96549206fe71?w=500&auto=format&fit=crop&q=60&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxzZWFyY2h8MXx8aW1hZ2V8ZW58MHx8MHx8fDA%3D" },
                    { 7, 6, "https://images.unsplash.com/photo-1575936123452-b67c3203c357?w=500&auto=format&fit=crop&q=60&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxzZWFyY2h8Mnx8aW1hZ2V8ZW58MHx8MHx8fDA%3D" },
                    { 8, 7, "https://plus.unsplash.com/premium_photo-1680553492268-516537c44d91?w=500&auto=format&fit=crop&q=60&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxzZWFyY2h8NXx8aW1hZ2V8ZW58MHx8MHx8fDA%3D" },
                    { 9, 8, "https://images.unsplash.com/photo-1488372759477-a7f4aa078cb6?w=500&auto=format&fit=crop&q=60&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxzZWFyY2h8NHx8aW1hZ2V8ZW58MHx8MHx8fDA%3D" },
                    { 10, 9, "https://images.unsplash.com/photo-1574169208507-84376144848b?w=500&auto=format&fit=crop&q=60&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxzZWFyY2h8Nnx8aW1hZ2V8ZW58MHx8MHx8fDA%3D" },
                    { 11, 10, "https://images.unsplash.com/photo-1566438480900-0609be27a4be?w=500&auto=format&fit=crop&q=60&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxzZWFyY2h8M3x8aW1hZ2V8ZW58MHx8MHx8fDA%3D" },
                    { 12, 11, "https://plus.unsplash.com/premium_photo-1664474619075-644dd191935f?w=500&auto=format&fit=crop&q=60&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxzZWFyY2h8OXx8aW1hZ2V8ZW58MHx8MHx8fDA%3D" },
                    { 13, 12, "https://images.unsplash.com/photo-1595147389795-37094173bfd8?w=500&auto=format&fit=crop&q=60&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxzZWFyY2h8MTF8fGltYWdlfGVufDB8fDB8fHww" },
                    { 14, 13, "https://images.unsplash.com/photo-1613323593608-abc90fec84ff?w=500&auto=format&fit=crop&q=60&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxzZWFyY2h8OHx8aW1hZ2V8ZW58MHx8MHx8fDA%3D" },
                    { 15, 14, "https://images.unsplash.com/photo-1574169207511-e21a21c8075a?w=500&auto=format&fit=crop&q=60&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxzZWFyY2h8MTJ8fGltYWdlfGVufDB8fDB8fHww" },
                    { 16, 15, "https://plus.unsplash.com/premium_photo-1687382111414-7b87afa5da34?w=500&auto=format&fit=crop&q=60&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxzZWFyY2h8MTN8fGltYWdlfGVufDB8fDB8fHww" },
                    { 17, 16, "https://images.unsplash.com/photo-1551021794-03be4ddaf67d?w=500&auto=format&fit=crop&q=60&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxzZWFyY2h8MTB8fGltYWdlfGVufDB8fDB8fHww" },
                    { 18, 17, "https://images.unsplash.com/photo-1628784230353-5bee16e2f005?w=500&auto=format&fit=crop&q=60&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxzZWFyY2h8MTZ8fGltYWdlfGVufDB8fDB8fHww" },
                    { 19, 18, "https://images.unsplash.com/photo-1598214886806-c87b84b7078b?w=500&auto=format&fit=crop&q=60&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxzZWFyY2h8MTV8fGltYWdlfGVufDB8fDB8fHww" }
                });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: 19);

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 13, 20, 12, 40, 787, DateTimeKind.Local).AddTicks(4212));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 13, 20, 12, 40, 787, DateTimeKind.Local).AddTicks(4231));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 13, 20, 12, 40, 787, DateTimeKind.Local).AddTicks(4233));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 13, 20, 12, 40, 787, DateTimeKind.Local).AddTicks(4234));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 13, 20, 12, 40, 788, DateTimeKind.Local).AddTicks(604));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 13, 20, 12, 40, 788, DateTimeKind.Local).AddTicks(611));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 13, 20, 12, 40, 788, DateTimeKind.Local).AddTicks(613));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 13, 20, 12, 40, 788, DateTimeKind.Local).AddTicks(614));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 13, 20, 12, 40, 788, DateTimeKind.Local).AddTicks(616));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 13, 20, 12, 40, 788, DateTimeKind.Local).AddTicks(618));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 13, 20, 12, 40, 788, DateTimeKind.Local).AddTicks(620));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 13, 20, 12, 40, 788, DateTimeKind.Local).AddTicks(621));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 13, 20, 12, 40, 788, DateTimeKind.Local).AddTicks(622));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 13, 20, 12, 40, 788, DateTimeKind.Local).AddTicks(624));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 13, 20, 12, 40, 788, DateTimeKind.Local).AddTicks(626));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 13, 20, 12, 40, 788, DateTimeKind.Local).AddTicks(628));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 13, 20, 12, 40, 788, DateTimeKind.Local).AddTicks(630));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 13, 20, 12, 40, 788, DateTimeKind.Local).AddTicks(631));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 13, 20, 12, 40, 788, DateTimeKind.Local).AddTicks(632));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 13, 20, 12, 40, 788, DateTimeKind.Local).AddTicks(633));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 13, 20, 12, 40, 788, DateTimeKind.Local).AddTicks(635));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 13, 20, 12, 40, 788, DateTimeKind.Local).AddTicks(637));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 13, 20, 12, 40, 789, DateTimeKind.Local).AddTicks(1775));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 13, 20, 12, 40, 789, DateTimeKind.Local).AddTicks(1782));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 13, 20, 12, 40, 789, DateTimeKind.Local).AddTicks(1783));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 13, 20, 12, 40, 789, DateTimeKind.Local).AddTicks(1785));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 13, 20, 12, 40, 789, DateTimeKind.Local).AddTicks(1786));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 13, 20, 12, 40, 789, DateTimeKind.Local).AddTicks(1789));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 13, 20, 12, 40, 789, DateTimeKind.Local).AddTicks(1790));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 13, 20, 12, 40, 789, DateTimeKind.Local).AddTicks(1792));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 13, 20, 12, 40, 789, DateTimeKind.Local).AddTicks(1793));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 13, 20, 12, 40, 789, DateTimeKind.Local).AddTicks(1823));
        }
    }
}
