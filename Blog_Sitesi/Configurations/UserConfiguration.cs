using Blog_Sitesi.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Security;

namespace Blog_Sitesi.Configurations
{
	public class UserConfiguration : IEntityTypeConfiguration<User>
	{
		void IEntityTypeConfiguration<User>.Configure(EntityTypeBuilder<User> builder)
		{
			builder.Property(user => user.CreatedAt).HasDefaultValueSql("GETDATE()");

			builder.Property(user => user.Name).HasMaxLength(20);
			builder.Property(user => user.Password).HasMaxLength(20);
			builder.Property(user => user.Role).HasMaxLength(6);
			
			



			builder.ToTable("Users", builder => builder.IsTemporal(true));


			//veri ekleme

			builder.HasData(new List<User>()
			{
				new User { UserId = 1, Name = "Ahmet", Email = "ahmet@gmail.com", Password = "123", Role = "admin", CreatedAt = DateTime.Now },
				new User { UserId = 2, Name = "Mehmet", Email = "mehmet@gmail.com", Password = "456", Role = "user", CreatedAt = DateTime.Now },
				new User { UserId = 3, Name = "Ayşe", Email = "ayse@gmail.com", Password = "789", Role = "user", CreatedAt = DateTime.Now },
				new User { UserId = 4, Name = "Fatma", Email = "fatma@gmail.com", Password = "abc", Role = "user", CreatedAt = DateTime.Now },
				new User { UserId = 5, Name = "Mustafa", Email = "mustafa@gmail.com", Password = "def", Role = "user", CreatedAt = DateTime.Now },
				new User { UserId = 6, Name = "Zeynep", Email = "zeynep@gmail.com", Password = "ghi", Role = "user", CreatedAt = DateTime.Now },
				new User { UserId = 7, Name = "Ali", Email = "ali@gmail.com", Password = "jkl", Role = "user", CreatedAt = DateTime.Now },
				new User { UserId = 8, Name = "Aysel", Email = "aysel@gmail.com", Password = "mno", Role = "user", CreatedAt = DateTime.Now },
				new User { UserId = 9, Name = "İsmail", Email = "ismail@gmail.com", Password = "pqr", Role = "user", CreatedAt = DateTime.Now },
				new User { UserId = 10, Name = "Hülya", Email = "hulya@gmail.com", Password = "stu", Role = "user", CreatedAt = DateTime.Now }
			});



		}
	}
}
