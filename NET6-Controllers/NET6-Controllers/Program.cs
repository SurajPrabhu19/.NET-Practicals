using NET6_Controllers.Controllers;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddTransient<HomeController>(); // if you want to use/register a single controller manually
builder.Services.AddControllers(); // this service adds/registers all controllers -> add all controllers to get used by the application

var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.Run();
