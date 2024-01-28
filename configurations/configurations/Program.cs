var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();
var app = builder.Build();

//app.MapGet("/", () => "Hello World!");

app.UseRouting();
app.UseEndpoints(endpoints =>
{
    endpoints.Map("/", async(context) =>
    {
        await context.Response.WriteAsync(app.Configuration["MyKey"]+"\n");  // way 1 to get value from appsetting.json
        await context.Response.WriteAsync(app.Configuration.GetValue<string>("MyKey") + "\n");     // way 2 to get value from appsetting.json
        //await context.Response.WriteAsync(app.Configuration.GetValue<string>("MyKey1"));     // way 2 to get value from appsetting.json
        await context.Response.WriteAsync(app.Configuration.GetValue<string>("MyKey2", "Key Not Found -> this is a default value sustituted")+"\n");     // way 2 to get value from appsetting.json
    });
});

app.Run();
