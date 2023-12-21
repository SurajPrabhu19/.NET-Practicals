var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.Run(async (HttpContext context) => { 
    context.Response.StatusCode = 200;
    context.Response.Headers["TempKey"] = "this is just a demo header";
    await context.Response.WriteAsync("Hello");
    await context.Response.WriteAsync("World Bro");
});
//Worldpp.MapGet("/", () => "Hello World!");

app.Run();
 