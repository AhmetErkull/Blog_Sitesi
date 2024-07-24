using Blog_Sitesi.Middlewares;

namespace Blog_Sitesi.Extensions
{
    public static class UseRouteMiddlewareExtension
    {
        public static IApplicationBuilder UseRouteMiddleware(this IApplicationBuilder builder, string path)
        {
            return builder.Map(path, b => b.UseMiddleware<RouteMiddleware>());
        }
    }
}
