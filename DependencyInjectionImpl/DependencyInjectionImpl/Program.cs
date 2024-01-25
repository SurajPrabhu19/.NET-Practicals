var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

// builder.Services -> add a service in the IOC (Inversion Of Control) Container
builder.Services.AddControllersWithViews();

app.MapGet("/", () => "Hello World!");

app.UseStaticFiles();
app.UseRouting();
app.MapControllers();
app.Run();
