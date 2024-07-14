using Blog_Sitesi.Models.Context;
using Blog_Sitesi.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Blog_Sitesi.ViewComponents
{
    public class PageNavigationViewComponent:ViewComponent
    {
        private readonly Context context;
        public PageNavigationViewComponent(Context context)
        {
            this.context = context;
        }

        public IViewComponentResult Invoke()
        {
            double postCount = context.Posts.Count();
            ViewBag.PostCount = Math.Ceiling(postCount/5);  
            return View("Components/PageNavigationComponent.cshtml");
        }
    }
}
