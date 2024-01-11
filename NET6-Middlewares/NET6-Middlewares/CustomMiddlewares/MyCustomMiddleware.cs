
using System.Runtime.CompilerServices;

namespace NET6_Middlewares.CustomMiddlewares
{
    public class MyCustomMiddleware : IMiddleware
    {
        public async Task InvokeAsync(HttpContext context, RequestDelegate next)
        {
            await context.Response.WriteAsync("Started MyCustomMiddleware\n");
            await next(context);
            await context.Response.WriteAsync("Completed MyCustomMiddleware\n");
        }
    }

    public static class MyCustomMiddlewareExtension
    {
        public static IApplicationBuilder UseMyCustomMiddleware(this IApplicationBuilder app)
        {
            return app.UseMiddleware<MyCustomMiddleware>();
        }
    }

}
