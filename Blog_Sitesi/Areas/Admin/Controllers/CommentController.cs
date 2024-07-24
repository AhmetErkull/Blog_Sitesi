using Blog_Sitesi.Models.Context;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using NuGet.Protocol;
using X.PagedList.Extensions;


namespace Blog_Sitesi.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CommentController : Controller
    {
        private readonly Context context;

        public CommentController(Context context) => this.context = context;

        public async Task<IActionResult> PostList(int? page)
        {
            int _page = page ?? 1;  
            var posts =  context.Posts.Include(x=>x.Comments).OrderByDescending(x=>x.PostId).AsNoTrackingWithIdentityResolution().ToPagedList(_page,10);
            TempData["PostPage"] = _page;
            return View(posts);
        }

        public async Task<IActionResult> CommentList(int postid, int? page, string title)
        {
            int _page = page ?? 1;
            var comments = context.Comments.Include(x=>x.User).Include(x => x.Post).Where(x => x.PostId == postid).OrderByDescending(x=>x.CommentId).
                AsNoTrackingWithIdentityResolution().ToPagedList(_page,10);
            ViewBag.Title = title;
            return View(comments);
        }
        public async Task<IActionResult> CommentDelete(int postid,int commentid)
        {
            var post = await context.Posts.Include(x => x.Comments).Where(x => x.PostId == postid).FirstOrDefaultAsync();
            var comment = await context.Comments.FindAsync(commentid);
            post.Comments.Remove(comment);
            await context.SaveChangesAsync();

            return RedirectToAction("CommentList", new {postid=postid}); 
        }
        


    }
}
