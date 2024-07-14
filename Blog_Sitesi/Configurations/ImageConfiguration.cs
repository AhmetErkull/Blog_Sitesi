using Blog_Sitesi.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Blog_Sitesi.Configurations
{
    public class ImageConfiguration : IEntityTypeConfiguration<Image>
    {
        void IEntityTypeConfiguration<Image>.Configure(EntityTypeBuilder<Image> builder)
        {
            builder.HasOne(image => image.Post).WithMany(post => post.Images).HasForeignKey(image => image.PostId);



            builder.HasData(new List<Image>()
            {
                new(){ImageId = 1,PostId = 1, Url = "https://letsenhance.io/static/8f5e523ee6b2479e26ecc91b9c25261e/1015f/MainAfter.jpg"},
                new(){ImageId = 2,PostId = 1, Url = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTuWXzkIYkMaVY24lJLPWFRS3WKI3kB3Ls0bg&s"},
                new(){ImageId = 3,PostId = 2, Url = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcREoRGyXmHy_6aIgXYqWHdOT3KjfmnuSyxypw&s"},
                new(){ImageId = 4,PostId = 3, Url = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTlJ2u482NBtw501OOICaZxGrIcxNtG5SuqWQ&s"},
                new(){ImageId = 5,PostId = 4, Url = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSxlT_-PpQJbt3DsWOZDQYohRy4YF8ck1n8PA&s"},
                new(){ImageId = 6,PostId = 5, Url = "https://plus.unsplash.com/premium_photo-1676637000058-96549206fe71?w=500&auto=format&fit=crop&q=60&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxzZWFyY2h8MXx8aW1hZ2V8ZW58MHx8MHx8fDA%3D"},
                new(){ImageId = 7,PostId = 6, Url = "https://images.unsplash.com/photo-1575936123452-b67c3203c357?w=500&auto=format&fit=crop&q=60&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxzZWFyY2h8Mnx8aW1hZ2V8ZW58MHx8MHx8fDA%3D"},
                new(){ImageId = 8,PostId = 7, Url = "https://plus.unsplash.com/premium_photo-1680553492268-516537c44d91?w=500&auto=format&fit=crop&q=60&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxzZWFyY2h8NXx8aW1hZ2V8ZW58MHx8MHx8fDA%3D"},
                new(){ImageId = 9,PostId = 8, Url = "https://images.unsplash.com/photo-1488372759477-a7f4aa078cb6?w=500&auto=format&fit=crop&q=60&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxzZWFyY2h8NHx8aW1hZ2V8ZW58MHx8MHx8fDA%3D"},
                new(){ImageId = 10,PostId = 9, Url = "https://images.unsplash.com/photo-1574169208507-84376144848b?w=500&auto=format&fit=crop&q=60&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxzZWFyY2h8Nnx8aW1hZ2V8ZW58MHx8MHx8fDA%3D"},
                new(){ImageId = 11,PostId = 10, Url = "https://images.unsplash.com/photo-1566438480900-0609be27a4be?w=500&auto=format&fit=crop&q=60&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxzZWFyY2h8M3x8aW1hZ2V8ZW58MHx8MHx8fDA%3D"},
                new(){ImageId = 12,PostId = 11, Url = "https://plus.unsplash.com/premium_photo-1664474619075-644dd191935f?w=500&auto=format&fit=crop&q=60&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxzZWFyY2h8OXx8aW1hZ2V8ZW58MHx8MHx8fDA%3D"},
                new(){ImageId = 13,PostId = 12, Url = "https://images.unsplash.com/photo-1595147389795-37094173bfd8?w=500&auto=format&fit=crop&q=60&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxzZWFyY2h8MTF8fGltYWdlfGVufDB8fDB8fHww"},
                new(){ImageId = 14,PostId = 13, Url = "https://images.unsplash.com/photo-1613323593608-abc90fec84ff?w=500&auto=format&fit=crop&q=60&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxzZWFyY2h8OHx8aW1hZ2V8ZW58MHx8MHx8fDA%3D"},
                new(){ImageId = 15,PostId = 14, Url = "https://images.unsplash.com/photo-1574169207511-e21a21c8075a?w=500&auto=format&fit=crop&q=60&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxzZWFyY2h8MTJ8fGltYWdlfGVufDB8fDB8fHww"},
                new(){ImageId = 16,PostId = 15, Url = "https://plus.unsplash.com/premium_photo-1687382111414-7b87afa5da34?w=500&auto=format&fit=crop&q=60&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxzZWFyY2h8MTN8fGltYWdlfGVufDB8fDB8fHww"},
                new(){ImageId = 17,PostId = 16, Url = "https://images.unsplash.com/photo-1551021794-03be4ddaf67d?w=500&auto=format&fit=crop&q=60&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxzZWFyY2h8MTB8fGltYWdlfGVufDB8fDB8fHww"},
                new(){ImageId = 18,PostId = 17, Url = "https://images.unsplash.com/photo-1628784230353-5bee16e2f005?w=500&auto=format&fit=crop&q=60&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxzZWFyY2h8MTZ8fGltYWdlfGVufDB8fDB8fHww"},
                new(){ImageId = 19,PostId = 18, Url = "https://images.unsplash.com/photo-1598214886806-c87b84b7078b?w=500&auto=format&fit=crop&q=60&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxzZWFyY2h8MTV8fGltYWdlfGVufDB8fDB8fHww"}
            });



        }
    }
}
