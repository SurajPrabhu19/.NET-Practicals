using Microsoft.EntityFrameworkCore;
using SessionInNetCore.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

// Registering DbContext Service:
var provider = builder.Services.BuildServiceProvider();
var config = provider.GetRequiredService<IConfiguration>();
builder.Services.AddDbContext<ProgramentorDbFirstContext>(item => item.UseSqlServer(config.GetConnectionString("dbconn")));

// Adding Session Service:
builder.Services.AddSession(session =>
{
    session.IdleTimeout = TimeSpan.FromSeconds(10); // Setting Session timeout to 10 sec
});

// adding service - IHttpContextAccessor for using Sessions in Views (.cshtml)
builder.Services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();

var app = builder.Build();

// Middleware to use Sessions:
app.UseSession();


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


// Run this for generating Models and DbContext: Scaffold-DbContext "server=LAPTOP-928V0DCI; database=ProgramentorDbFirst; trusted_connection=true;" Microsoft.EntityFrameworkCore.SqlServer -OutputDir Models
// Force update the Models and DbContext: Scaffold-DbContext "server=LAPTOP-928V0DCI; database=ProgramentorDbFirst; trusted_connection=true;" Microsoft.EntityFrameworkCore.SqlServer -OutputDir Models -force