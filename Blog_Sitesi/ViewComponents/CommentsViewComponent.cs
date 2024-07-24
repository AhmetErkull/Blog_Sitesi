using Blog_Sitesi.Models.Context;
using Blog_Sitesi.Models.Entities;
using Blog_Sitesi.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Blog_Sitesi.ViewComponents
{
    public class CommentsViewComponent:ViewComponent
    {
        private readonly Context context;
        public CommentsViewComponent(Context context) => this.context = context;

        public async Task<IViewComponentResult> InvokeAsync(int postid)
        {
            var comments = await context.Comments.Include(x => x.User).Include(x => x.Post).Where(x => x.PostId == postid).
                 AsNoTrackingWithIdentityResolution().ToListAsync();

            return View("Components/CommentsComponent.cshtml", comments);
        }
    }
}
