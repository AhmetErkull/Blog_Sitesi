using Blog_Sitesi.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Blog_Sitesi.Configurations
{
	public class PostTagConfiguration : IEntityTypeConfiguration<PostTag>
	{
		void IEntityTypeConfiguration<PostTag>.Configure(EntityTypeBuilder<PostTag> builder)
		{
			builder.HasKey(posttag => new
			{
				posttag.PostId,
				posttag.TagId
			});

			builder.HasOne(posttag => posttag.Post).WithMany(post => post.Tags).HasForeignKey(posttag => posttag.PostId);
			builder.HasOne(posttag => posttag.Tag).WithMany(tag => tag.Posts).HasForeignKey(posttag => posttag.TagId);



			// veri ekleme

			builder.HasData(new List<PostTag>()
			{
			new(){PostId = 1, TagId = 2},
			new(){PostId = 2, TagId = 2},
			new(){PostId = 2, TagId = 3},
			new(){PostId = 2, TagId = 4},
			new(){PostId = 3, TagId = 4},
             new() { PostId = 4, TagId = 5 },
			new() { PostId = 4, TagId = 6 },
			new() { PostId = 5, TagId = 7 },
			new() { PostId = 6, TagId = 5 },
			new() { PostId = 6, TagId = 8 },
			new() { PostId = 7, TagId = 9 },
			new() { PostId = 8, TagId = 10 },
			new() { PostId = 9, TagId = 7 },
			new() { PostId = 9, TagId = 11 },
			new() { PostId = 10, TagId = 12 },
			new() { PostId = 11, TagId = 13 },
			new() { PostId = 12, TagId = 14 },
			new() { PostId = 13, TagId = 15 },
			new() { PostId = 14, TagId = 16 },
			new() { PostId = 15, TagId = 17 },
			new() { PostId = 16, TagId = 18 },
			new() { PostId = 17, TagId = 19 },
			new() { PostId = 18, TagId = 20 }
            });

		}
	}
}
