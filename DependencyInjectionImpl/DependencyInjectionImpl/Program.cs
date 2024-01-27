using Services;
using ServicesContracts;

var builder = WebApplication.CreateBuilder(args);
// IOC -> builder.Services -> add a service in the IOC (Inversion Of Control) Container
// DIP -> Dependency Inversion Principle -> 2 classes shud be linked to each other by Interface
// DI -> Injecting or creating dependency of other service automatically
builder.Services.AddControllersWithViews();
//builder.Services.Add(new ServiceDescriptor(
//    typeof(ICityService), typeof(CityService), ServiceLifetime.Transient));
//builder.Services.Add(new ServiceDescriptor(typeof(ICityService), typeof(CityService), ServiceLifetime.Scoped)); // adding a service with scoped service lifetime
builder.Services.AddTransient<ICityService, CityService>(); // can keep one at a time to avoid comfusion
builder.Services.AddScoped<ICityService, CityService>();
builder.Services.AddSingleton<ICityService, CityService>();
var app = builder.Build();


app.UseStaticFiles();
app.UseRouting();
app.MapControllers();

app.Run();
