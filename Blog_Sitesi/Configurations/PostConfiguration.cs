using Blog_Sitesi.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Blog_Sitesi.Configurations
{
	public class PostConfiguration : IEntityTypeConfiguration<Post>
	{
		void IEntityTypeConfiguration<Post>.Configure(EntityTypeBuilder<Post> builder)
		{
			builder.Property(post => post.CreatedAt).HasDefaultValueSql("GETDATE()");
			builder.Property(post => post.Title).HasMaxLength(100);
			builder.Property(post => post.ViewCount).HasDefaultValue(0);

			builder.HasOne(post => post.Category).WithMany(category=>category.Posts).HasForeignKey(post => post.CategoryId);

			builder.HasOne(post => post.User).WithMany(user => user.Posts).HasForeignKey(post => post.UserId);

		

			builder.HasData(new List<Post>()
			{
				new(){PostId = 1, Content = "bir şeyler bir şeyler", CategoryId = 1, CreatedAt = DateTime.Now, Title ="başlık1", UserId = 3},
				new(){PostId = 2, Content = "burada şunu anlatıyoruz", CategoryId = 2, CreatedAt = DateTime.Now, Title ="başlık2", UserId = 2},
				new(){PostId = 3, Content = "bu da böyle bir post", CategoryId = 1, CreatedAt = DateTime.Now, Title ="başlık3", UserId = 1},
                 new() { PostId = 4, Content = "Yeni teknoloji trendleri üzerine düşüncelerimiz.", CategoryId = 3, CreatedAt = DateTime.Now, Title = "Teknoloji Trendleri", UserId = 2 },
    new() { PostId = 5, Content = "Geleceğin eğitim sistemleri nasıl olacak?", CategoryId = 4, CreatedAt = DateTime.Now, Title = "Geleceğin Eğitimi", UserId = 3 },
    new() { PostId = 6, Content = "Yazılım geliştirme süreçlerindeki en büyük zorluklarımız.", CategoryId = 3, CreatedAt = DateTime.Now, Title = "Yazılım Geliştirme Zorlukları", UserId = 1 },
    new() { PostId = 7, Content = "Sağlık sektöründe yapay zeka kullanımı üzerine düşünceler.", CategoryId = 5, CreatedAt = DateTime.Now, Title = "Yapay Zeka ve Sağlık", UserId = 3 },
    new() { PostId = 8, Content = "Geleceğin seyahat trendleri ve tahminlerimiz.", CategoryId = 6, CreatedAt = DateTime.Now, Title = "Geleceğin Seyahatleri", UserId = 2 },
    new() { PostId = 9, Content = "Sanal gerçeklik teknolojilerinin eğitimdeki potansiyeli.", CategoryId = 4, CreatedAt = DateTime.Now, Title = "Sanal Gerçeklik ve Eğitim", UserId = 1 },
    new() { PostId = 10, Content = "Girişimcilikte en önemli başarı faktörleri nelerdir?", CategoryId = 7, CreatedAt = DateTime.Now, Title = "Girişimcilik Başarı Faktörleri", UserId = 2 },
    new() { PostId = 11, Content = "Sosyal medyanın geleceği ve değişen dinamikler.", CategoryId = 8, CreatedAt = DateTime.Now, Title = "Sosyal Medyanın Geleceği", UserId = 3 },
    new() { PostId = 12, Content = "Yapay zeka ve otomasyonun endüstriyel etkileri üzerine bir değerlendirme.", CategoryId = 5, CreatedAt = DateTime.Now, Title = "Yapay Zeka ve Endüstri", UserId = 1 },
    new() { PostId = 13, Content = "Çevresel sürdürülebilirlik ve iş dünyasındaki rolü.", CategoryId = 9, CreatedAt = DateTime.Now, Title = "Çevresel Sürdürülebilirlik", UserId = 2 },
    new() { PostId = 14, Content = "Blockchain teknolojisinin finans sektöründeki yenilikçi kullanımları.", CategoryId = 10, CreatedAt = DateTime.Now, Title = "Blockchain ve Finans", UserId = 3 },
    new() { PostId = 15, Content = "E-ticaretin geleceği ve değişen tüketici alışkanlıkları.", CategoryId = 11, CreatedAt = DateTime.Now, Title = "E-ticaretin Geleceği", UserId = 1 },
    new() { PostId = 16, Content = "Yeni nesil mobil uygulama geliştirme trendleri üzerine düşünceler.", CategoryId = 12, CreatedAt = DateTime.Now, Title = "Mobil Uygulama Trendleri", UserId = 2 },
    new() { PostId = 17, Content = "Yapay zeka ve günlük yaşam üzerindeki etkileri.", CategoryId = 5, CreatedAt = DateTime.Now, Title = "Yapay Zeka ve Günlük Hayat", UserId = 3 },
    new() { PostId = 18, Content = "Geleceğin enerji ihtiyaçları ve sürdürülebilir enerji çözümleri.", CategoryId = 9, CreatedAt = DateTime.Now, Title = "Geleceğin Enerji İhtiyaçları", UserId = 1 }
            });

		}
	}
}
