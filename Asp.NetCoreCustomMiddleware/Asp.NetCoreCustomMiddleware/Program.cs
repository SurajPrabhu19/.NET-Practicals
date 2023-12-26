//var builder = WebApplication.CreateBuilder(args);
//var app = builder.Build();

////app.MapGet("/", () => "Hello World!");

////app.Run(async (HttpContext context) =>
////{
////    await context.Response.WriteAsync("Custom Middle ware 1 \n");
////});

////app.Run(); runs only one time and doesnt move to next command/middleware if any
//// therefore we use "app.Use((HttpContext context,RequestDelegate next) => { await next(context);})
//// to not just stop there but continue executing the next middleware


//app.Use(async (HttpContext context,RequestDelegate next) =>
//{
//    await context.Response.WriteAsync("Custom Middle ware 1 \n");
//    await next(context);
//});

//app.Use(async (HttpContext context,RequestDelegate next) =>
//{
//    await context.Response.WriteAsync("Custom Middle ware 2 \n");
//    await next(context);
//});

//app.Run(async (HttpContext context) =>
//{
//    await context.Response.WriteAsync("Inside app.run() \n");
//});

//app.Use(async (HttpContext context,RequestDelegate next) =>
//{
//    await context.Response.WriteAsync("Custom Middle ware 3 \n");
//    await next(context);
//});

//app.Run();

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

//app.MapGet("/", () => "Hello World!");

//app.Run(async (HttpContext context) =>
//{
//    await context.Response.WriteAsync("Custom Middle ware 1 \n");
//});

//app.Run(); runs only one time and doesnt move to next command/middleware if any
// therefore we use "app.Use((HttpContext context,RequestDelegate next) => { await next(context);})
// to not just stop there but continue executing the next middleware


app.Use(async (HttpContext context, RequestDelegate next) =>
{
    await context.Response.WriteAsync("Custom Middle ware 1 start\n");
    await next(context);
    await context.Response.WriteAsync("Custom Middle ware 1 end \n");
});

app.Use(async (HttpContext context, RequestDelegate next) =>
{
    await context.Response.WriteAsync("Custom Middle ware 2 \n");
    await next(context);
    await context.Response.WriteAsync("Custom Middle ware 2 end \n");
});

app.Run(async (HttpContext context) =>
{
    await context.Response.WriteAsync("Inside app.run() \n");
    await context.Response.WriteAsync("app.run() end \n");
});

app.Use(async (HttpContext context, RequestDelegate next) =>
{
    await context.Response.WriteAsync("Custom Middle ware 3 \n");
    await next(context);
    await context.Response.WriteAsync("Custom Middle ware 3 end \n");
});

app.Run();

