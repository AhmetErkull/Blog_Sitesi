using Blog_Sitesi.Models.Context;
using Blog_Sitesi.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;

namespace Blog_Sitesi.Helpers
{
    public static class TagHelper
    {
        public static void RemoveTagsFromPost(Context context, ref Post newpost)
        {
            var tagsToRemove = newpost.Tags.ToList();
            foreach (var tag in tagsToRemove)
            {
                context.Entry(tag).State = EntityState.Deleted;
            }
            newpost.Tags.Clear();
        }
        public static void AddTagsToPost(Context context, string SelectedTags, ref Post newpost)
        {
            var selectedTags = SelectedTags?.Split(',').Select(int.Parse).ToList();
            if (selectedTags != null && selectedTags.Any())
            {
                foreach (var tagid in selectedTags)
                {
                    newpost.Tags.Add(new PostTag() { TagId = tagid });
                }

            }
        }
    }
}
