var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();

var app = builder.Build();

if(!app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();    // displaying Exception page only for development env
}

app.UseStaticFiles();
app.UseRouting();
app.MapControllers();

app.Run();
