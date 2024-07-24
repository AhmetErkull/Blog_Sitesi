namespace Blog_Sitesi.Configurations
{
    public static class RouteConfiguration
    {
        public static void ConfigureRoutes(IEndpointRouteBuilder endpoints)
        {
            endpoints.MapControllerRoute(
                name: "Login",
                pattern: "Login/",
                defaults: new { controller = "Login", action = "Login" });

            endpoints.MapControllerRoute(
                name: "PostsByQuery",
                pattern: "Posts/",
                defaults: new { controller = "Home", action = "PostsBySearch" });

            endpoints.MapControllerRoute(
                name: "PostsByTag",
                pattern: "Tag/{tagname}",
                defaults: new { controller = "Home", action = "PostsByTag" });

            endpoints.MapControllerRoute(
                name: "PostsByCategory",
                pattern: "Category/{categoryname}",
                defaults: new { controller = "Home", action = "PostsByCategory" });

            endpoints.MapControllerRoute(
                name: "PostDetay",
                pattern: "Posts/{id}",
                defaults: new { controller = "Home", action = "PostSingle" });

            endpoints.MapControllerRoute(
                name: "Page",
                pattern: "Page/{page}",
                defaults: new { controller = "Home", action = "Index" });


            endpoints.MapControllerRoute(
                name: "adminIndex",
                pattern: "Admin/{action}",
                defaults: new { area = "Admin", controller = "Home", action = "Index" });

            endpoints.MapControllerRoute(
                name: "adminDefault",
                pattern: "{area:exists}/{controller}/{action}/{id?}");

            endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
        }
    }
}