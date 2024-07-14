using Blog_Sitesi.Models.Context;
using Blog_Sitesi.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Blog_Sitesi.ViewComponents
{
    public class PopulerPostsViewComponent:ViewComponent
    {
        private readonly Context context;
        public PopulerPostsViewComponent(Context context)
        {
            this.context = context;
        }

        public IViewComponentResult Invoke()
        {
            var posts = context.Posts.OrderByDescending(x => x.ViewCount).Take(3).Include(x => x.Images).Select(x => new PostsWithImageViewModel()
            {
                Title = x.Title,
                ImageUrl = x.Images.FirstOrDefault().Url.ToString(),
                CreatedAt = x.CreatedAt
            }).ToList();
            return View("Components/PopulerPostsComponent.cshtml", posts);
        }
    }
}
