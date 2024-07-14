using Blog_Sitesi.Models.Context;
using Blog_Sitesi.Models.Entities;
using Blog_Sitesi.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Blog_Sitesi.ViewComponents
{
    public class TagsViewComponent:ViewComponent
    {
        private readonly Context context;
        public TagsViewComponent(Context context)
        {
            this.context = context;

        }
        public IViewComponentResult Invoke()
        {
            List<Tag> tags = context.Tags.AsNoTracking().ToList(); 


            return View("Components/TagsComponent.cshtml", tags);
        }
    }
}
