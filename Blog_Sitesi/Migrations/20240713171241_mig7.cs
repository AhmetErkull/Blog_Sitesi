using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Blog_Sitesi.Migrations
{
    /// <inheritdoc />
    public partial class mig7 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "Description", "Name" },
                values: new object[,]
                {
                    { 4, "Eğitim ile ilgili konular", "Eğitim" },
                    { 5, "Sağlık teknolojileri ve sağlık hizmetleri", "Sağlık" },
                    { 6, "Seyahat ve turizm", "Seyahat" },
                    { 7, "Girişimcilik ve iş dünyası", "Girişimcilik" },
                    { 8, "Sosyal medya platformları ve etkileri", "Sosyal Medya" },
                    { 9, "Çevresel sürdürülebilirlik ve yeşil teknolojiler", "Çevre" },
                    { 10, "Finansal piyasalar ve yenilikçi finansal teknolojiler", "Finans" },
                    { 11, "Online ticaret platformları ve e-ticaret trendleri", "E-ticaret" },
                    { 12, "Mobil uygulama geliştirme ve mobil teknolojiler", "Mobil Uygulamalar" },
                    { 13, "Sanayi ve endüstriyel süreçlerdeki yenilikler", "Endüstri" },
                    { 14, "Veri analizi ve büyük veri teknolojileri", "Veri Bilimi" }
                });

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

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "PostId", "CategoryId", "Content", "CreatedAt", "Title", "UserId" },
                values: new object[,]
                {
                    { 4, 3, "Yeni teknoloji trendleri üzerine düşüncelerimiz.", new DateTime(2024, 7, 13, 20, 12, 40, 788, DateTimeKind.Local).AddTicks(614), "Teknoloji Trendleri", 2 },
                    { 6, 3, "Yazılım geliştirme süreçlerindeki en büyük zorluklarımız.", new DateTime(2024, 7, 13, 20, 12, 40, 788, DateTimeKind.Local).AddTicks(618), "Yazılım Geliştirme Zorlukları", 1 }
                });

            migrationBuilder.InsertData(
                table: "Tags",
                columns: new[] { "TagId", "TagName" },
                values: new object[,]
                {
                    { 5, "Teknoloji Trendleri" },
                    { 6, "Eğitim Sistemleri" },
                    { 7, "Yazılım Geliştirme" },
                    { 8, "Sanal Gerçeklik" },
                    { 9, "Sağlık Teknolojileri" },
                    { 10, "Seyahat Trendleri" },
                    { 11, "Girişimcilik" },
                    { 12, "Sosyal Medya" },
                    { 13, "Endüstri 4.0" },
                    { 14, "Çevresel Sürdürülebilirlik" },
                    { 15, "Blockchain" },
                    { 16, "E-ticaret" },
                    { 17, "Mobil Uygulama Geliştirme" },
                    { 18, "Yapay Zeka Günlük Hayat" },
                    { 19, "Enerji İhtiyaçları" },
                    { 20, "Veri Analitiği" }
                });

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

            migrationBuilder.InsertData(
                table: "PostTag",
                columns: new[] { "PostId", "TagId" },
                values: new object[,]
                {
                    { 4, 5 },
                    { 4, 6 },
                    { 6, 5 },
                    { 6, 8 }
                });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "PostId", "CategoryId", "Content", "CreatedAt", "Title", "UserId" },
                values: new object[,]
                {
                    { 5, 4, "Geleceğin eğitim sistemleri nasıl olacak?", new DateTime(2024, 7, 13, 20, 12, 40, 788, DateTimeKind.Local).AddTicks(616), "Geleceğin Eğitimi", 3 },
                    { 7, 5, "Sağlık sektöründe yapay zeka kullanımı üzerine düşünceler.", new DateTime(2024, 7, 13, 20, 12, 40, 788, DateTimeKind.Local).AddTicks(620), "Yapay Zeka ve Sağlık", 3 },
                    { 8, 6, "Geleceğin seyahat trendleri ve tahminlerimiz.", new DateTime(2024, 7, 13, 20, 12, 40, 788, DateTimeKind.Local).AddTicks(621), "Geleceğin Seyahatleri", 2 },
                    { 9, 4, "Sanal gerçeklik teknolojilerinin eğitimdeki potansiyeli.", new DateTime(2024, 7, 13, 20, 12, 40, 788, DateTimeKind.Local).AddTicks(622), "Sanal Gerçeklik ve Eğitim", 1 },
                    { 10, 7, "Girişimcilikte en önemli başarı faktörleri nelerdir?", new DateTime(2024, 7, 13, 20, 12, 40, 788, DateTimeKind.Local).AddTicks(624), "Girişimcilik Başarı Faktörleri", 2 },
                    { 11, 8, "Sosyal medyanın geleceği ve değişen dinamikler.", new DateTime(2024, 7, 13, 20, 12, 40, 788, DateTimeKind.Local).AddTicks(626), "Sosyal Medyanın Geleceği", 3 },
                    { 12, 5, "Yapay zeka ve otomasyonun endüstriyel etkileri üzerine bir değerlendirme.", new DateTime(2024, 7, 13, 20, 12, 40, 788, DateTimeKind.Local).AddTicks(628), "Yapay Zeka ve Endüstri", 1 },
                    { 13, 9, "Çevresel sürdürülebilirlik ve iş dünyasındaki rolü.", new DateTime(2024, 7, 13, 20, 12, 40, 788, DateTimeKind.Local).AddTicks(630), "Çevresel Sürdürülebilirlik", 2 },
                    { 14, 10, "Blockchain teknolojisinin finans sektöründeki yenilikçi kullanımları.", new DateTime(2024, 7, 13, 20, 12, 40, 788, DateTimeKind.Local).AddTicks(631), "Blockchain ve Finans", 3 },
                    { 15, 11, "E-ticaretin geleceği ve değişen tüketici alışkanlıkları.", new DateTime(2024, 7, 13, 20, 12, 40, 788, DateTimeKind.Local).AddTicks(632), "E-ticaretin Geleceği", 1 },
                    { 16, 12, "Yeni nesil mobil uygulama geliştirme trendleri üzerine düşünceler.", new DateTime(2024, 7, 13, 20, 12, 40, 788, DateTimeKind.Local).AddTicks(633), "Mobil Uygulama Trendleri", 2 },
                    { 17, 5, "Yapay zeka ve günlük yaşam üzerindeki etkileri.", new DateTime(2024, 7, 13, 20, 12, 40, 788, DateTimeKind.Local).AddTicks(635), "Yapay Zeka ve Günlük Hayat", 3 },
                    { 18, 9, "Geleceğin enerji ihtiyaçları ve sürdürülebilir enerji çözümleri.", new DateTime(2024, 7, 13, 20, 12, 40, 788, DateTimeKind.Local).AddTicks(637), "Geleceğin Enerji İhtiyaçları", 1 }
                });

            migrationBuilder.InsertData(
                table: "PostTag",
                columns: new[] { "PostId", "TagId" },
                values: new object[,]
                {
                    { 5, 7 },
                    { 7, 9 },
                    { 8, 10 },
                    { 9, 7 },
                    { 9, 11 },
                    { 10, 12 },
                    { 11, 13 },
                    { 12, 14 },
                    { 13, 15 },
                    { 14, 16 },
                    { 15, 17 },
                    { 16, 18 },
                    { 17, 19 },
                    { 18, 20 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "PostTag",
                keyColumns: new[] { "PostId", "TagId" },
                keyValues: new object[] { 4, 5 });

            migrationBuilder.DeleteData(
                table: "PostTag",
                keyColumns: new[] { "PostId", "TagId" },
                keyValues: new object[] { 4, 6 });

            migrationBuilder.DeleteData(
                table: "PostTag",
                keyColumns: new[] { "PostId", "TagId" },
                keyValues: new object[] { 5, 7 });

            migrationBuilder.DeleteData(
                table: "PostTag",
                keyColumns: new[] { "PostId", "TagId" },
                keyValues: new object[] { 6, 5 });

            migrationBuilder.DeleteData(
                table: "PostTag",
                keyColumns: new[] { "PostId", "TagId" },
                keyValues: new object[] { 6, 8 });

            migrationBuilder.DeleteData(
                table: "PostTag",
                keyColumns: new[] { "PostId", "TagId" },
                keyValues: new object[] { 7, 9 });

            migrationBuilder.DeleteData(
                table: "PostTag",
                keyColumns: new[] { "PostId", "TagId" },
                keyValues: new object[] { 8, 10 });

            migrationBuilder.DeleteData(
                table: "PostTag",
                keyColumns: new[] { "PostId", "TagId" },
                keyValues: new object[] { 9, 7 });

            migrationBuilder.DeleteData(
                table: "PostTag",
                keyColumns: new[] { "PostId", "TagId" },
                keyValues: new object[] { 9, 11 });

            migrationBuilder.DeleteData(
                table: "PostTag",
                keyColumns: new[] { "PostId", "TagId" },
                keyValues: new object[] { 10, 12 });

            migrationBuilder.DeleteData(
                table: "PostTag",
                keyColumns: new[] { "PostId", "TagId" },
                keyValues: new object[] { 11, 13 });

            migrationBuilder.DeleteData(
                table: "PostTag",
                keyColumns: new[] { "PostId", "TagId" },
                keyValues: new object[] { 12, 14 });

            migrationBuilder.DeleteData(
                table: "PostTag",
                keyColumns: new[] { "PostId", "TagId" },
                keyValues: new object[] { 13, 15 });

            migrationBuilder.DeleteData(
                table: "PostTag",
                keyColumns: new[] { "PostId", "TagId" },
                keyValues: new object[] { 14, 16 });

            migrationBuilder.DeleteData(
                table: "PostTag",
                keyColumns: new[] { "PostId", "TagId" },
                keyValues: new object[] { 15, 17 });

            migrationBuilder.DeleteData(
                table: "PostTag",
                keyColumns: new[] { "PostId", "TagId" },
                keyValues: new object[] { 16, 18 });

            migrationBuilder.DeleteData(
                table: "PostTag",
                keyColumns: new[] { "PostId", "TagId" },
                keyValues: new object[] { 17, 19 });

            migrationBuilder.DeleteData(
                table: "PostTag",
                keyColumns: new[] { "PostId", "TagId" },
                keyValues: new object[] { 18, 20 });

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "TagId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "TagId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "TagId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "TagId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "TagId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "TagId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "TagId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "TagId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "TagId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "TagId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "TagId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "TagId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "TagId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "TagId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "TagId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "TagId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 12);

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
    }
}
