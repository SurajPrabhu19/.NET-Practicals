var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

// USING Middlewares: ----------------------------------------------------------------------------------
//app.Map("/Home", () => "Universal map function that takes all kind of result");
//app.MapGet("/Home", () => "Map Get Function");
//app.MapPost("/Home", () => "Map Post Function");
//app.MapPut("/Home", () => "Map Put Function");
//app.MapDelete("/Home", () => "Map Delete Function");

// here for each route || "/Home" || we have a delegate function i.e. || () => {"Hello"} || also know as request delegate
// -----------------------------------------------------------------------------------------------------

// USING Endpoints: ------------------------------------------------------------------------------------
app.UseRouting();

// these middlewares are used to implement custom based logic:
app.UseEndpoints(endpoints =>
{
    endpoints.MapGet("/Home", async (context) => { await context.Response.WriteAsync("Endpoint for Http GET"); });
    endpoints.MapPut("/Home", async (context) => { await context.Response.WriteAsync("Endpoint for Http PUT"); });
    endpoints.MapPost("/Home", async (context) => { await context.Response.WriteAsync("Endpoint for Http POST"); });
    endpoints.MapDelete("/Home", async (context) => { await context.Response.WriteAsync("Endpoint for Http Delete"); });
});
//-------------------------------------------------------------------------------------------------------


app.Run();
