using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Blog_Sitesi.Migrations
{
    /// <inheritdoc />
    public partial class mig1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.CategoryId);
                });

            migrationBuilder.CreateTable(
                name: "Tags",
                columns: table => new
                {
                    TagId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TagName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tags", x => x.TagId);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Role = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.UserId);
                });

            migrationBuilder.CreateTable(
                name: "Posts",
                columns: table => new
                {
                    PostId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Posts", x => x.PostId);
                    table.ForeignKey(
                        name: "FK_Posts_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "CategoryId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Posts_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Comments",
                columns: table => new
                {
                    CommentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PostId = table.Column<int>(type: "int", nullable: true),
                    UserId = table.Column<int>(type: "int", nullable: true),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comments", x => x.CommentId);
                    table.ForeignKey(
                        name: "PostId",
                        column: x => x.PostId,
                        principalTable: "Posts",
                        principalColumn: "PostId");
                    table.ForeignKey(
                        name: "UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "UserId");
                });

            migrationBuilder.CreateTable(
                name: "PostTag",
                columns: table => new
                {
                    PostId = table.Column<int>(type: "int", nullable: false),
                    TagId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PostTag", x => new { x.PostId, x.TagId });
                    table.ForeignKey(
                        name: "FK_PostTag_Posts_PostId",
                        column: x => x.PostId,
                        principalTable: "Posts",
                        principalColumn: "PostId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PostTag_Tags_TagId",
                        column: x => x.TagId,
                        principalTable: "Tags",
                        principalColumn: "TagId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "Description", "Name" },
                values: new object[,]
                {
                    { 1, "Teknolojik şeyler", "Teknoloji" },
                    { 2, "Sanat ve Kültür şeyler", "Sanat ve Kültür" },
                    { 3, "Kişisel Gelişim şeyler", "Kişisel Gelişim" }
                });

            migrationBuilder.InsertData(
                table: "Tags",
                columns: new[] { "TagId", "TagName" },
                values: new object[,]
                {
                    { 1, "Yapay Zeka" },
                    { 2, "Veri Bilimi" },
                    { 3, "Web Geliştirme" },
                    { 4, "Mobil Uygulamalar" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "CreatedAt", "Email", "Name", "Password", "Role" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 7, 12, 20, 14, 21, 890, DateTimeKind.Local).AddTicks(1179), "ahmet@gmail.com", "Ahmet", "123", "admin" },
                    { 2, new DateTime(2024, 7, 12, 20, 14, 21, 890, DateTimeKind.Local).AddTicks(1186), "mehmet@gmail.com", "Mehmet", "456", "user" },
                    { 3, new DateTime(2024, 7, 12, 20, 14, 21, 890, DateTimeKind.Local).AddTicks(1187), "ayse@gmail.com", "Ayşe", "789", "user" },
                    { 4, new DateTime(2024, 7, 12, 20, 14, 21, 890, DateTimeKind.Local).AddTicks(1189), "fatma@gmail.com", "Fatma", "abc", "user" },
                    { 5, new DateTime(2024, 7, 12, 20, 14, 21, 890, DateTimeKind.Local).AddTicks(1190), "mustafa@gmail.com", "Mustafa", "def", "user" },
                    { 6, new DateTime(2024, 7, 12, 20, 14, 21, 890, DateTimeKind.Local).AddTicks(1193), "zeynep@gmail.com", "Zeynep", "ghi", "user" },
                    { 7, new DateTime(2024, 7, 12, 20, 14, 21, 890, DateTimeKind.Local).AddTicks(1194), "ali@gmail.com", "Ali", "jkl", "user" },
                    { 8, new DateTime(2024, 7, 12, 20, 14, 21, 890, DateTimeKind.Local).AddTicks(1196), "aysel@gmail.com", "Aysel", "mno", "user" },
                    { 9, new DateTime(2024, 7, 12, 20, 14, 21, 890, DateTimeKind.Local).AddTicks(1197), "ismail@gmail.com", "İsmail", "pqr", "user" },
                    { 10, new DateTime(2024, 7, 12, 20, 14, 21, 890, DateTimeKind.Local).AddTicks(1200), "hulya@gmail.com", "Hülya", "stu", "user" }
                });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "PostId", "CategoryId", "Content", "CreatedAt", "Title", "UserId" },
                values: new object[,]
                {
                    { 1, 1, "bir şeyler bir şeyler", new DateTime(2024, 7, 12, 20, 14, 21, 889, DateTimeKind.Local).AddTicks(2401), "başlık1", 3 },
                    { 2, 2, "burada şunu anlatıyoruz", new DateTime(2024, 7, 12, 20, 14, 21, 889, DateTimeKind.Local).AddTicks(2406), "başlık2", 2 },
                    { 3, 1, "bu da böyle bir post", new DateTime(2024, 7, 12, 20, 14, 21, 889, DateTimeKind.Local).AddTicks(2407), "başlık3", 1 }
                });

            migrationBuilder.InsertData(
                table: "Comments",
                columns: new[] { "CommentId", "Content", "CreatedAt", "PostId", "UserId" },
                values: new object[,]
                {
                    { 1, "çok güzeldi teşekkürler", new DateTime(2024, 7, 12, 20, 14, 21, 888, DateTimeKind.Local).AddTicks(7981), 1, 2 },
                    { 2, "dostum naber", new DateTime(2024, 7, 12, 20, 14, 21, 888, DateTimeKind.Local).AddTicks(7994), 1, 2 },
                    { 3, "vay canına", new DateTime(2024, 7, 12, 20, 14, 21, 888, DateTimeKind.Local).AddTicks(7996), 1, 3 },
                    { 4, "çok bilgilendiriciydi", new DateTime(2024, 7, 12, 20, 14, 21, 888, DateTimeKind.Local).AddTicks(7997), 2, 2 }
                });

            migrationBuilder.InsertData(
                table: "PostTag",
                columns: new[] { "PostId", "TagId" },
                values: new object[,]
                {
                    { 1, 2 },
                    { 2, 2 },
                    { 2, 3 },
                    { 2, 4 },
                    { 3, 4 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Comments_PostId",
                table: "Comments",
                column: "PostId");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_UserId",
                table: "Comments",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Posts_CategoryId",
                table: "Posts",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Posts_UserId",
                table: "Posts",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_PostTag_TagId",
                table: "PostTag",
                column: "TagId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Comments");

            migrationBuilder.DropTable(
                name: "PostTag");

            migrationBuilder.DropTable(
                name: "Posts");

            migrationBuilder.DropTable(
                name: "Tags");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
