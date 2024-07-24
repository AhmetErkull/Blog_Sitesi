using Blog_Sitesi.Models.Context;
using Blog_Sitesi.Models.Entities;
using Blog_Sitesi.Models.ViewModels;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Blog_Sitesi.Controllers
{
    public class LoginController : Controller
    {
        private readonly Context context;

        public LoginController(Context context) => this.context = context;

        public IActionResult Login()
        {
            ClaimsPrincipal claimuser = HttpContext.User;

            if (claimuser.Identity.IsAuthenticated)
                    return RedirectToAction("Index", "Home", new { area = "Admin" });

            return View();
        }



        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel user)
        {
            var admin = await context.Users.FirstOrDefaultAsync(x => x.Name == user.Name && x.Password == user.Password);
            if (admin != null)
            {
                List<Claim> claims = new() {
                new Claim(ClaimTypes.Name,user.Name)
                };

                ClaimsIdentity claimsIdentity = new(claims, "Login");

                AuthenticationProperties authenticationProperties = new()
                {
                    AllowRefresh = true,
                    IsPersistent = user.KeepLoggedIn
                };

                await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme,
                    new ClaimsPrincipal(claimsIdentity), authenticationProperties);

                return RedirectToAction("Index", "Home", new { area = "Admin" });

            }
            else
            {
                ViewData["ValidationMessage"] = "Kullanıcı bulunamadı";
                return View(user);
            }

        }
        public IActionResult AccessDenied()
        {
            return View();
        }


    }
}
