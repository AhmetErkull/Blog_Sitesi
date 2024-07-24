namespace Blog_Sitesi.Middlewares
{
    public class RouteMiddleware
    {
        RequestDelegate next;
        public RouteMiddleware(RequestDelegate next) => this.next = next;

        public async Task Invoke(HttpContext context)
        {
            await next.Invoke(context);
        }
    }
}
