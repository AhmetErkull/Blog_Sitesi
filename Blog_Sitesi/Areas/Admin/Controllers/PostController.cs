using Blog_Sitesi.Extensions;
using Blog_Sitesi.Helpers;
using Blog_Sitesi.Models.Context;
using Blog_Sitesi.Models.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using NuGet.Packaging;
using X.PagedList.Extensions;

namespace Blog_Sitesi.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class PostController : Controller
    {

        private readonly Context context;

        public PostController(Context context) => this.context = context;

        public async Task<IActionResult> PostList(int? page)
        {
            int _page = page ?? 1;
            var posts = context.Posts
                                     .Include(x => x.Category)
                                     .Include(x => x.Images)
                                     .Include(x => x.Tags)
                                        .ThenInclude(pt => pt.Tag).OrderByDescending(x=>x.PostId)
                                     .AsNoTrackingWithIdentityResolution().ToPagedList(_page, 4);

            return View(posts);
        }
        public async Task<IActionResult> PostCreate()
        {
            var categories = await context.Categories.AsNoTracking().
                Select(x =>new SelectListItem(){Value = x.CategoryId.ToString(),Text = x.Name }).ToListAsync();
            ViewBag.Categories = categories;

            var tags = await context.Tags.AsNoTracking().ToListAsync();
            ViewBag.Tags = tags;

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> PostCreate(Post post,string images, string SelectedTags)
        {
            User user = await context.Users.FirstOrDefaultAsync();
            if (user != null)
            {
                post.UserId = user.UserId;
            }
            post.UserId = user.UserId;

            ImageHelper.AddImagesToPost(ref post, images);

            var selectedTags = SelectedTags?.Split(',').Select(int.Parse).ToList();
            if (selectedTags != null && selectedTags.Any())
            {
                foreach (var tagid in selectedTags)
                {
                    post.Tags.Add(new PostTag() {TagId = tagid } );
                }
               
            }

            ModelState.RemoveRange(nameof(Category), nameof(User), nameof(images),nameof(selectedTags));

            if (ModelState.IsValid)
            {
                await context.Posts.AddAsync(post);
                await context.SaveChangesAsync();
                return RedirectToAction("PostList");
            }
            else
            {
                return View(post);
            }
        }

    

        public async Task<IActionResult> PostDelete(int id)
        {
            var post = await context.Posts.FindAsync(id);
            context.Posts.Remove(post);
            await context.SaveChangesAsync();
            return RedirectToAction("PostList");
        }

        public async Task<IActionResult> PostEdit(int id)
        {
            var post = await context.Posts.Include(x=>x.Images).Include(x=>x.Tags).AsNoTrackingWithIdentityResolution().FirstOrDefaultAsync(x=>x.PostId == id);

            var categories = await context.Categories.AsNoTracking().
                Select(x => new SelectListItem() { Value = x.CategoryId.ToString(), Text = x.Name }).ToListAsync();
            ViewBag.Categories = categories;

            var tags = await context.Tags.AsNoTracking().ToListAsync();
            ViewBag.Tags = tags;

            return View(post);
        }
        [HttpPost]
        public async Task<IActionResult> PostEdit(Post post, string images, string SelectedTags)
        {

            ModelState.RemoveRange(nameof(Category), nameof(User), nameof(images), nameof(SelectedTags));

            if (ModelState.IsValid)
            {
                var newpost = await context.Posts.Include(x=>x.Tags).FirstOrDefaultAsync(x=>x.PostId == post.PostId);

                newpost.Title = post.Title;
                newpost.Content = post.Content;
                newpost.CategoryId = post.CategoryId;

                TagHelper.RemoveTagsFromPost(context, ref newpost);

                TagHelper.AddTagsToPost(context, SelectedTags, ref newpost);

                await context.SaveChangesAsync();

                return RedirectToAction("PostList");
            }
            else
            {
                return View(post);
            }

        }

       
    }
}
