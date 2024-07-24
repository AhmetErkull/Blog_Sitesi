using Blog_Sitesi.Models.Context;
using Blog_Sitesi.Models.Entities;

namespace Blog_Sitesi.Helpers
{
    public static class ImageHelper
    {
        public static void AddImagesToPost(ref Post post, string images)
        {
            if (!string.IsNullOrEmpty(images))
            {
                var urls = images.Split(new[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);
                foreach (var url in urls)
                {
                    post.Images.Add(new Image { Url = url.Trim() });
                }
            }
        }
        public static void RemoveImagesFromPost(Context context,int postid,ref Post newpost)
        {
            var imagesToRemove = context.Images.Where(x => x.PostId == postid).ToList();
            foreach (var image in imagesToRemove)
            {
                newpost.Images.Remove(image);
            }
        }
    }
}
