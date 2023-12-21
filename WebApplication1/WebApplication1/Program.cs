var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.Run(async (HttpContext context) => { 
    context.Response.StatusCode = 200;
    context.Response.Headers["TempKey"] = "this is just a demo header";
    context.Response.ContentType = "text/html";
    // text/plain, text/html, application/json, application/xml // these are the various content types you use
    await context.Response.WriteAsync("<h1>Hello</h1>");
    await context.Response.WriteAsync("<h2>World Bro</h2>");
});
//Worldpp.MapGet("/", () => "Hello World!");

app.Run();
 