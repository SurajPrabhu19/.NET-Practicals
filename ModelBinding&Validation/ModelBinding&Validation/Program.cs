var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

builder.Services.AddControllersWithViews();

app.MapGet("/", () => "Hello World!");

app.UseRouting();
app.MapControllers();

app.Run();
