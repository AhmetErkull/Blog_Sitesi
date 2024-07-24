using Blog_Sitesi.AutoMappers;
using Blog_Sitesi.Configurations;
using Blog_Sitesi.Filters;
using Blog_Sitesi.Middlewares;
using Blog_Sitesi.Models.Context;
using Blog_Sitesi.Models.Entities;
using FluentValidation.AspNetCore;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Authorization;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.FileSystemGlobbing.Internal;
using System;
using System.Security;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews().AddFluentValidation(x=>x.RegisterValidatorsFromAssemblyContaining<Program>());
builder.Services.AddAutoMapper(typeof(CommentProfil),typeof(UserProfil));

builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
    .AddCookie(CookieAuthenticationDefaults.AuthenticationScheme, options =>
    {
        options.LoginPath = "/Login";
        options.LogoutPath = "/Logout";
        options.AccessDeniedPath = "/Login/AccessDenied";
        options.ExpireTimeSpan = TimeSpan.FromMinutes(20);
    });

builder.Services.AddMvc(config =>
{
    var generalPolicy = new AuthorizationPolicyBuilder()
        .RequireAuthenticatedUser() 
        .Build();
    config.Conventions.Add(new AdminAreaAuthorization(generalPolicy));
});


builder.Configuration
	.AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
	.AddUserSecrets<Program>();

var connectionString = builder.Configuration.GetConnectionString("SQL");


//builder.Services.AddTransient<Context>();
builder.Services.AddDbContext<Context>(options => options.UseSqlServer(connectionString,builder=> builder.EnableRetryOnFailure()));

var app = builder.Build();


if (!app.Environment.IsDevelopment())
{
	app.UseExceptionHandler("/Home/Error");
	
	app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();



app.UseRouting();
app.UseAuthorization();
app.UseAuthentication();



//app.MapControllerRoute(
//    name: "Login",
//    pattern: "Login/",
//    new { controller = "Login", action = "Login" });

//app.MapControllerRoute(
//    name: "PostsByQuery",
//    pattern: "Posts/",
//    new { controller = "Home", action = "PostsBySearch" });

//app.MapControllerRoute(
//    name: "PostsByTag",
//    pattern: "Tag/{tagname}",
//    new { controller = "Home", action = "PostsByTag" });

//app.MapControllerRoute(
//    name: "PostsByCategory",
//    pattern: "Category/{categoryname}",
//    new { controller = "Home", action = "PostsByCategory" });

//app.MapControllerRoute(
//    name: "PostDetay",
//    pattern: "Posts/{id}",
//    new { controller = "Home", action = "PostSingle" });

//app.MapControllerRoute(
//    name: "Page",
//    pattern: "Page/{page}",
//    new { controller = "Home", action = "Index" });

//app.MapControllerRoute(
//    name: "adminIndex",
//    pattern: "Admin/{action}",
//    defaults: new { area = "Admin", controller = "Home", action = "Index" });


//app.MapControllerRoute(
//    name: "adminDefault",
//    pattern: "{area:exists}/{controller}/{action}/{id?}");

app.UseMiddleware<RouteMiddleware>();

app.UseEndpoints(endpoints =>
{
    RouteConfiguration.ConfigureRoutes(endpoints);
});


//app.MapDefaultControllerRoute();

app.Run();



