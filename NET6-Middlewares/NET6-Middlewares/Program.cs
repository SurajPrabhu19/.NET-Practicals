using NET6_Middlewares.CustomMiddlewares;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.Use(async (HttpContext context, RequestDelegate next) =>
{
    await context.Response.WriteAsync("Started Use 1\n");
    await next(context);    // next() in Use() will redirect to the next middleware else Use() will act as Run() i.e as a terminating middleware
    await context.Response.WriteAsync("Completed Use 1\n");
});
// Use() -> this extension is used to add middleware extension that may or may not forward request to the next middleware

app.Use(async (context, next) =>
{
    await context.Response.WriteAsync("Started Use 2\n");
    await next(context);
    await context.Response.WriteAsync("Completed Use 2\n");
});

//app.UseMiddleware<MyCustomMiddleware>();    // adding custom middleware
app.UseMyCustomMiddleware();    // adding custom middleware - using static extension class

app.Run(async (context) =>
{
    await context.Response.WriteAsync("Inside Run - Line 1\n");
    await context.Response.WriteAsync("Inside Run - Line 2\n");
    await context.Response.WriteAsync("Inside Run - Line 3\n");
});
// run() -> basically a terminating or short-circuit extension 
// i.e no command will run after this extension is executed
