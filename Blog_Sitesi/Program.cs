using Blog_Sitesi.Models.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.FileSystemGlobbing.Internal;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddControllersWithViews();

builder.Configuration
	.AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
	.AddUserSecrets<Program>();

var connectionString = builder.Configuration.GetConnectionString("SQL");

builder.Services.AddDbContext<Context>(options => options.UseSqlServer(connectionString));

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

app.MapControllerRoute(
	name: "Hakkinda",
	pattern: "About",
	new { controller = "Home", action = "About" });

app.MapControllerRoute(
    name: "Page",
    pattern: "Page/{page}",
    new { controller = "Home", action = "Index" });

app.MapDefaultControllerRoute();

app.Run();

