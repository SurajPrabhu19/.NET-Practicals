var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();
builder.Services.AddHttpClient();

var app = builder.Build();

//app.MapGet("/", () => "Hello World!");
app.UseStaticFiles();
app.UseRouting();
app.MapControllers();


app.Run();
