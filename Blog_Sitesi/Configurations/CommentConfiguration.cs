using Blog_Sitesi.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Blog_Sitesi.Configurations
{
	public class CommentConfiguration : IEntityTypeConfiguration<Comment>
	{
		void IEntityTypeConfiguration<Comment>.Configure(EntityTypeBuilder<Comment> builder)
		{
			builder.Property(comment => comment.CreatedAt).HasDefaultValueSql("GETDATE()");
			builder.Property(comment => comment.Content).HasMaxLength(140);

			builder.HasOne(comment => comment.User).WithMany(user => user.Comments).HasForeignKey(comment => comment.UserId).HasConstraintName("UserId").OnDelete(DeleteBehavior.NoAction);
			
			builder.HasOne(comment => comment.Post).WithMany(post => post.Comments).HasForeignKey(comment => comment.PostId).HasConstraintName("PostId").OnDelete(DeleteBehavior.NoAction); 
			// veri ekleme

			builder.HasData(new List<Comment>()
			{
				new() {CommentId = 1, Content = "çok güzeldi teşekkürler", PostId = 1, UserId = 2, CreatedAt = DateTime.Now },
				new() {CommentId = 2, Content = "dostum naber", PostId = 1, UserId = 2, CreatedAt = DateTime.Now },
				new() {CommentId = 3, Content = "vay canına", PostId = 1, UserId = 3, CreatedAt = DateTime.Now },
				new() {CommentId = 4, Content = "çok bilgilendiriciydi", PostId = 2, UserId = 2, CreatedAt = DateTime.Now },
				
			});
		}
	}
}
