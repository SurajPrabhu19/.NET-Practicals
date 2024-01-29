using configurations.Options;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();
// Stores an object of MyAppDataOptions type with data prefilled from the appsetting.json section
builder.Services.Configure<MyAppDataOptions>(builder.Configuration.GetSection("MyAppData2"));

var app = builder.Build();

//app.MapGet("/", () => "Hello World!");

app.UseStaticFiles();
app.UseRouting();
app.UseEndpoints(endpoints =>
{
    endpoints.Map("/", async(context) =>
    {
        await context.Response.WriteAsync(app.Configuration["MyKey"]+"\n");  // way 1 to get value from appsetting.json // line 1 added
        await context.Response.WriteAsync(app.Configuration.GetValue<string>("MyKey") + "\n");     // way 2 to get value from appsetting.json // line 2 added
        // not working //await context.Response.WriteAsync(app.Configuration.GetValue<string>("MyKey1"));     // way 2 to get value from appsetting.json
        await context.Response.WriteAsync(app.Configuration.GetValue<string>("MyKey2", "Key Not Found -> this is a default value sustituted")+"\n");     // way 2 to get value from appsetting.json // line 3 added
    
    });
});
app.MapControllers();
app.Run();
