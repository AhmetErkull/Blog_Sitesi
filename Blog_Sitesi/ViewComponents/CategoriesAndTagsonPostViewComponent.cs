using Blog_Sitesi.Models.Context;
using Blog_Sitesi.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Blog_Sitesi.ViewComponents
{
    public class CategoriesAndTagsonPostViewComponent:ViewComponent
    {
        private readonly Context context;
        public CategoriesAndTagsonPostViewComponent(Context context)
        {
            this.context = context;

        }
        public async Task<IViewComponentResult> InvokeAsync(int postid)
        {

            var categoriesandtags = await context.Posts.Include(x => x.Category).Include(x => x.Tags).Where(x => x.PostId == postid).
                Select(x => new PostWithCategoriesAndTagsViewModel()
            {
                PostId = postid,
                CategoryName = x.Category.Name,
                TagNames = x.Tags.Select(x=>x.Tag.TagName).ToList()
            }).
                AsNoTrackingWithIdentityResolution().FirstOrDefaultAsync();
            return View("Components/CategoriesAndTagsonPostComponent.cshtml", categoriesandtags);
        }
    }
}
