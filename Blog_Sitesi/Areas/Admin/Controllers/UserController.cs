using AutoMapper;
using Blog_Sitesi.Models.Context;
using Blog_Sitesi.Models.Entities;
using Blog_Sitesi.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.CodeDom;
using X.PagedList.Extensions;

namespace Blog_Sitesi.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class UserController : Controller
    {
        readonly private Context context;
        public IMapper mapper;
        public UserController(Context context, IMapper mapper) {
            this.context = context;
            this.mapper = mapper;
        }
        public IActionResult UserList(int page=1)
        {
            var userlist = this.context.Users.OrderByDescending(x=>x.UserId).AsNoTracking().ToPagedList(page,10);
            return View(userlist);
        }
        public IActionResult UserCreate()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> UserCreate(UserViewModel model)
        {
            User user = mapper.Map<User>(model);
            if (ModelState.IsValid)
            {
                await context.Users.AddAsync(user);
                await context.SaveChangesAsync();
                return RedirectToAction("UserList");
            }
            else
            {
                return View(user);
            }
        }
        public async Task<IActionResult> UserDelete(int id)
        {
            var user = await context.Users.FindAsync(id);
            context.Users.Remove(user);
            await context.SaveChangesAsync();
            return RedirectToAction("UserList");
        }
        public async Task<IActionResult> UserEdit(int id)
        {
            var user = await context.Users.FindAsync(id);
            UserViewModel model = mapper.Map<UserViewModel>(user);
            return View(model);
        }
        [HttpPost]
        public async Task<IActionResult> UserEdit(UserViewModel model)
        {
            User user = mapper.Map<User>(model);
            if (ModelState.IsValid)
            {
                var newuser = await context.Users.FindAsync(user.UserId);
                newuser.Name = user.Name;
                newuser.Password = user.Password;
                newuser.Email = user.Email;
                await context.SaveChangesAsync();

                return RedirectToAction(nameof(UserList));
            }
            else
            {
                return View(user);
            }

        }
    }
}
