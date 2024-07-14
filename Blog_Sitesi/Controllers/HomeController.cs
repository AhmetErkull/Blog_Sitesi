using Blog_Sitesi.Models;
using Blog_Sitesi.Models.Context;
using Blog_Sitesi.Models.Entities;
using Blog_Sitesi.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace Blog_Sitesi.Controllers
{
	
	public class HomeController : Controller
	{
		private readonly ILogger<HomeController> _logger;

        private readonly Context context;

        public HomeController(ILogger<HomeController> logger, Context context)
		{
			this.context = context;
			_logger = logger;
		}
			
		public IActionResult Index(int page = 1)
		{
			const int pageSize = 5;

			int startIndex = (page - 1) * pageSize;

			var posts = context.Posts
		   .Include(p => p.Tags).ThenInclude(pt => pt.Tag)
		   .Include(p => p.Images)
		   .Skip(startIndex)
		   .Take(pageSize)
		   .Select(p => new PostSummaryViewModel()
		   {
			   Title = p.Title,
			   Content = p.Content,
			   ImageUrl = p.Images.FirstOrDefault().Url,
			   CreatedAt = p.CreatedAt,
			   TagNames = p.Tags.Select(pt => pt.Tag.TagName).Take(4).ToList<string>()
		   }).AsNoTrackingWithIdentityResolution().ToList();

			return View(posts);
		}


		public IActionResult About()
		{
			return View();
		}

		[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
		public IActionResult Error()
		{
			return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
		}
	}
}
