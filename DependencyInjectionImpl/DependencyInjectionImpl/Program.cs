using Services;
using ServicesContracts;

var builder = WebApplication.CreateBuilder(args);
// builder.Services -> add a service in the IOC (Inversion Of Control) Container
builder.Services.AddControllersWithViews();
builder.Services.Add(new ServiceDescriptor(
    typeof(ICityService), typeof(CityService), ServiceLifetime.Transient));
var app = builder.Build();


app.UseStaticFiles();
app.UseRouting();
app.MapControllers();

app.Run();
