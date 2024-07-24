using Blog_Sitesi.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Blog_Sitesi.Configurations
{
	public class TagConfiguration : IEntityTypeConfiguration<Tag>
	{
		void IEntityTypeConfiguration<Tag>.Configure(EntityTypeBuilder<Tag> builder)
		{
			// veri ekleme

			builder.HasData(new List<Tag>()
			{
				new() { TagId = 1, TagName = "Yapay Zeka" },
				new() { TagId = 2, TagName = "Veri Bilimi" },
				new() { TagId = 3, TagName = "Web Geliştirme" },
				new() { TagId = 4, TagName = "Mobil Uygulamalar" },
                new() { TagId = 5, TagName = "Teknoloji Trendleri" },
                new() { TagId = 6, TagName = "Eğitim Sistemleri" },
                new() { TagId = 7, TagName = "Yazılım Geliştirme" },
                new() { TagId = 8, TagName = "Sanal Gerçeklik" },
                new() { TagId = 9, TagName = "Sağlık Teknolojileri" },
                new() { TagId = 10, TagName = "Seyahat Trendleri" },
                new() { TagId = 11, TagName = "Girişimcilik" },
                new() { TagId = 12, TagName = "Sosyal Medya" },
                new() { TagId = 13, TagName = "Endüstri 4.0" },
                new() { TagId = 14, TagName = "Çevresel Sürdürülebilirlik" },
                new() { TagId = 15, TagName = "Blockchain" },
                new() { TagId = 16, TagName = "E-ticaret" },
                new() { TagId = 17, TagName = "Mobil Uygulama Geliştirme" },
                new() { TagId = 18, TagName = "Yapay Zeka Günlük Hayat" },
                new() { TagId = 19, TagName = "Enerji İhtiyaçları" },
                new() { TagId = 20, TagName = "Veri Analitiği" }
            });
		}
	
				
		
	}
}
