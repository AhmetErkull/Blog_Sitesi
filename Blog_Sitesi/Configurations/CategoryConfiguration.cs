using Blog_Sitesi.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Blog_Sitesi.Configurations
{
	public class CategoryConfiguration : IEntityTypeConfiguration<Category>
	{
		void IEntityTypeConfiguration<Category>.Configure(EntityTypeBuilder<Category> builder)
		{
			builder.Property(category => category.Name).HasMaxLength(25);
			builder.Property(category => category.Description).HasMaxLength(150);

			//veri ekleme

			builder.HasData(new List<Category>()
			{
				new(){CategoryId = 1,  Name = "Teknoloji", Description = "Teknolojik şeyler"},
				new(){CategoryId = 2,  Name = "Sanat ve Kültür", Description = "Sanat ve Kültür şeyler"},
				new(){CategoryId = 3,  Name = "Kişisel Gelişim", Description = "Kişisel Gelişim şeyler"},
                 new() { CategoryId = 4, Name = "Eğitim", Description = "Eğitim ile ilgili konular" },
				new() { CategoryId = 5, Name = "Sağlık", Description = "Sağlık teknolojileri ve sağlık hizmetleri" },
				new() { CategoryId = 6, Name = "Seyahat", Description = "Seyahat ve turizm" },
				new() { CategoryId = 7, Name = "Girişimcilik", Description = "Girişimcilik ve iş dünyası" },
				new() { CategoryId = 8, Name = "Sosyal Medya", Description = "Sosyal medya platformları ve etkileri" },
				new() { CategoryId = 9, Name = "Çevre", Description = "Çevresel sürdürülebilirlik ve yeşil teknolojiler" },
				new() { CategoryId = 10, Name = "Finans", Description = "Finansal piyasalar ve yenilikçi finansal teknolojiler" },
				new() { CategoryId = 11, Name = "E-ticaret", Description = "Online ticaret platformları ve e-ticaret trendleri" },
				new() { CategoryId = 12, Name = "Mobil Uygulamalar", Description = "Mobil uygulama geliştirme ve mobil teknolojiler" },
				new() { CategoryId = 13, Name = "Endüstri", Description = "Sanayi ve endüstriyel süreçlerdeki yenilikler" },
				new() { CategoryId = 14, Name = "Veri Bilimi", Description = "Veri analizi ve büyük veri teknolojileri" }
            });
		}
	}
}
