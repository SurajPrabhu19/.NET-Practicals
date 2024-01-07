using DBFirst_EntityFramework.Models;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews(); // Add services to the container.

// Registering DbContext Service for ProgrammentorDbFirst database
var provider = builder.Services.BuildServiceProvider();
var config = provider.GetRequiredService<IConfiguration>();
builder.Services.AddDbContext<ProgramentorDbFirstContext>(item => item.UseSqlServer(config.GetConnectionString("dbconn")));

builder.Services.AddSession();  // Adding feature to use Session.
builder.Services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>(); // adding service of <IHttpContextAccessor>

var app = builder.Build();

app.UseSession(); // middle-ware to use Sesssions

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
