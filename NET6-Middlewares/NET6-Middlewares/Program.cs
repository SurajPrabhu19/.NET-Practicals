var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.Use(async (HttpContext context, RequestDelegate next) =>
{
    await context.Response.WriteAsync("Inside Use"); 
    await next(context);    // next() in Use() will redirect to the next middleware else Use() will act as Run() i.e as a terminating middleware
});
// Use() -> this extension is used to add middleware extension that may or may not forward request to the next middleware

app.Run((context) => { return context.Response.WriteAsync("Inside Run"); });
// run() -> basically a terminating or short-circuit extension 
// i.e no command will run after this extension is executed


app.Run();
