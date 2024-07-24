using AutoMapper;
using Blog_Sitesi.Models;
using Blog_Sitesi.Models.Context;
using Blog_Sitesi.Models.Entities;
using Blog_Sitesi.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.Diagnostics;

namespace Blog_Sitesi.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        public IMapper autoMapper;

        private readonly Context context;

        public HomeController(ILogger<HomeController> logger, Context context, IMapper mapper)
        {
            this.autoMapper = mapper;
            this.context = context;
            _logger = logger;
        }

        public async Task<IActionResult> Index(int page = 1)
        {
            const int pageSize = 5;

            int startIndex = (page - 1) * pageSize;

            var posts = await context.Posts
           .Include(p => p.Tags).ThenInclude(pt => pt.Tag)
           .Include(p => p.Images)
           .Skip(startIndex)
           .Take(pageSize)
           .Select(p => new PostSummaryViewModel()
           {
               Id = p.PostId,
               Title = p.Title,
               Content = p.Content,
               ImageUrl = p.Images.FirstOrDefault().Url,
               CreatedAt = p.CreatedAt,
               TagNames = p.Tags.Select(pt => pt.Tag.TagName).Take(4).ToList<string>()
           }).AsNoTrackingWithIdentityResolution().ToListAsync();

            return View(posts);
        }

        public async Task<IActionResult> PostSingle(int id)
        {
            var post = await context.Posts
            .Where(x => x.PostId == id)
            .Include(p => p.Tags)
                .ThenInclude(pt => pt.Tag)
            .Include(p => p.Images)
            .Select(p => new PostDetailsViewModel
            {
                Id = p.PostId,
                Title = p.Title,
                Content = p.Content,
                ImageUrls = p.Images.Select(x => x.Url).ToList(),
                CreatedAt = p.CreatedAt,
                TagNames = p.Tags
                    .Select(pt => pt.Tag.TagName)
                    .ToList()
            })
            .AsNoTrackingWithIdentityResolution()
            .FirstOrDefaultAsync();

            if (post == null)
            {
                return NotFound();
            }

            return View(post);

        }

        [HttpPost]
        public async Task<IActionResult> LeaveComment(CommentsOfPostViewModel commentvm) 
        {
            Comment comment = autoMapper.Map<Comment>(commentvm);
            comment.UserId = 1;
            await context.Comments.AddAsync(comment);
            await context.SaveChangesAsync();

            return RedirectToAction("PostSingle", new {id = comment.PostId});
           
        }


        public async Task<IActionResult> PostsByCategory(string categoryname)
        {
            var postsByCategory = await context.Posts
                .Include(p => p.Category)
                .Include(p => p.Tags)
                    .ThenInclude(pt => pt.Tag)
                .Include(p => p.Images)
                .Where(p => p.Category.Name == categoryname)
                .Select(p => new PostsByCategoryViewModel
                {
                    Id = p.PostId,
                    CategoryName = p.Category.Name,
                    Title = p.Title,
                    Content = p.Content,
                    ImageUrl = p.Images.FirstOrDefault().Url,
                    CreatedAt = p.CreatedAt,
                    TagNames = p.Tags.Select(pt => pt.Tag.TagName).Take(4).ToList()
                })
                .AsNoTrackingWithIdentityResolution()
                .ToListAsync();

            if (!postsByCategory.Any())
            {
                return NotFound(); ;
            }

            return View(postsByCategory);
        }
        public async Task<IActionResult> PostsByTag(string tagname)
        {
            var postsByCategory = await context.Posts
             .Include(p => p.Tags)
                 .ThenInclude(pt => pt.Tag)
             .Include(p => p.Images)
             .Where(p => p.Tags.Any(x => x.Tag.TagName == tagname))
             .Select(p => new PostsByTagViewModel
             {
                 Id = p.PostId,
                 TagName = tagname, 
                 Title = p.Title,
                 Content = p.Content,
                 ImageUrl = p.Images.FirstOrDefault().Url,
                 CreatedAt = p.CreatedAt,
                 TagNames = p.Tags.Select(pt => pt.Tag.TagName).Take(4).ToList()
             })
             .AsNoTrackingWithIdentityResolution()
             .ToListAsync();


            if (!postsByCategory.Any())
            {
                return NotFound();
            }

            return View(postsByCategory);
        }

        public async Task<IActionResult> PostsBySearch(string query)
        {

            var posts = await context.Posts
         .Include(p => p.Tags).ThenInclude(pt => pt.Tag)
         .Include(p => p.Images)
         .Where(p => p.Content.Contains(query) ||
                     p.Title.Contains(query) ||
                     p.Tags.Any(pt => pt.Tag.TagName.Contains(query)) ||
                     p.Category.Name.Contains(query))
         .Select(p => new PostSummaryViewModel
         {
               Id = p.PostId,
               Title = p.Title,
               Content = p.Content,
               ImageUrl = p.Images.FirstOrDefault().Url,
               CreatedAt = p.CreatedAt,
               TagNames = p.Tags.Select(pt => pt.Tag.TagName).Take(4).ToList<string>()
           }).AsNoTrackingWithIdentityResolution().ToListAsync();

            return View("Index",posts);
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
