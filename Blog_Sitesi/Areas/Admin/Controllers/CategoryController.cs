using Blog_Sitesi.Models.Context;
using Blog_Sitesi.Models.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using X.PagedList.Extensions;

namespace Blog_Sitesi.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CategoryController : Controller
    {
        private readonly Context context;

        public CategoryController(Context context) => this.context = context;

        public async Task<IActionResult> CategoryList(int? page)
        {
            int _page = page?? 1;
            var categories = context.Categories.AsNoTracking().OrderByDescending(x=>x.CategoryId).ToPagedList(_page,10);
            return View(categories);
        }
        public async Task<IActionResult> CategoryCreate()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> CategoryCreate(Category category)
        {
            if (ModelState.IsValid)
            {
                await context.Categories.AddAsync(category);
                await context.SaveChangesAsync();
                return RedirectToAction("CategoryList");
            }
            else
            {
                return View(category);
            }
        }

        public async Task<IActionResult> CategoryDelete(int id)
        {
            var category = await context.Categories.FindAsync(id);
            context.Categories.Remove(category);
            await context.SaveChangesAsync();
            return RedirectToAction("CategoryList");
        }

        public async Task<IActionResult> CategoryEdit(int id)
        {
            var category = await context.Categories.FindAsync(id);

            return View(category);
        }
        [HttpPost]
        public async Task<IActionResult> CategoryEdit(Category category)
        {
            if (ModelState.IsValid)
            {
                var newcategory = await context.Categories.FindAsync(category.CategoryId);
                newcategory.Name = category.Name;
                newcategory.Description = category.Description;
                await context.SaveChangesAsync();

                return RedirectToAction("CategoryList");
            }
            else
            {
                return View(category);
            }
         
        }
    }
}
