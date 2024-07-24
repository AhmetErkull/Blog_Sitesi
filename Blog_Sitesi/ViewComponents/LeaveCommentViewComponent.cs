using Blog_Sitesi.Models.Context;
using Blog_Sitesi.Models.Entities;
using Blog_Sitesi.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Xml.Linq;

namespace Blog_Sitesi.ViewComponents
{
    public class LeaveCommentViewComponent:ViewComponent
    {
        private readonly Context context;
        public LeaveCommentViewComponent(Context context)
        {
            this.context = context;

        }
        public IViewComponentResult Invoke(int postid)
        {
            CommentsOfPostViewModel model = new();
            model.PostId = postid;
            return View("Components/LeaveCommentComponent.cshtml", model);
        }
    }
}
