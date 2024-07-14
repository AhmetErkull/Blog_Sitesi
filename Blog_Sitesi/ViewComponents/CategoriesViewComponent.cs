using Blog_Sitesi.Models.Context;
using Blog_Sitesi.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Blog_Sitesi.ViewComponents
{
    public class CategoriesViewComponent:ViewComponent
    {
        private readonly Context context;
        public CategoriesViewComponent(Context context)
        {
            this.context = context;

        }
        public IViewComponentResult Invoke()
        {
            var categories = (from category in context.Categories
                             join post in context.Posts
                             on category.CategoryId equals post.CategoryId
                             into grup
                             select new CategoryWithPostCountViewModel()
                             {
                                 CategoryName = category.Name,
                                 PostCount = grup.Count()
                             }).AsNoTrackingWithIdentityResolution().ToList();


            return View("Components/CategoriesComponent.cshtml", categories);
        }
    }
}
