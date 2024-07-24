using Azure;
using Blog_Sitesi.Models.Context;
using Blog_Sitesi.Models.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using X.PagedList.Extensions;

namespace Blog_Sitesi.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class TagController : Controller
    {
        private readonly Context context;

        public TagController(Context context) => this.context = context;
        public async Task<ActionResult> TagList(int? page)
        {
            int _page = page ?? 1;  
            var tags =  context.Tags.OrderByDescending(x => x.TagId).AsNoTracking().ToPagedList(_page,10);
            return View(tags);
        }

        public async Task<IActionResult> TagCreate()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> TagCreate(Tag tag)
        {
            if (ModelState.IsValid)
            {
                await context.Tags.AddAsync(tag);
                await context.SaveChangesAsync();
                return RedirectToAction("TagList");
            }
            else
            {
                return View(tag);
            }
        }

        public async Task<IActionResult> TagDelete(int id)
        {
            var tag = await context.Tags.FindAsync(id);
            context.Tags.Remove(tag);
            await context.SaveChangesAsync();
            return RedirectToAction("TagList");
        }

        public async Task<IActionResult> TagEdit(int id)
        {
            var tag = await context.Tags.FindAsync(id);

            return View(tag);
        }
        [HttpPost]
        public async Task<IActionResult> TagEdit(Tag tag)
        {
            if (ModelState.IsValid)
            {
                var newtag = await context.Tags.FindAsync(tag.TagId);
                newtag.TagName = tag.TagName;
                await context.SaveChangesAsync();

                return RedirectToAction("TagList");
            }
            else
            {
                return View(tag);
            }

        }
    }
}
