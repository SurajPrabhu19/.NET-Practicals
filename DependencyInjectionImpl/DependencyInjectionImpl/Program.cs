using Services;
using ServicesContracts;

var builder = WebApplication.CreateBuilder(args);
// IOC -> builder.Services -> add a service in the IOC (Inversion Of Control) Container
// DIP -> Dependency Inversion Principle -> 2 classes shud be linked to each other by Interface
// DI -> Injecting or creating dependency of other service automatically
builder.Services.AddControllersWithViews();
builder.Services.Add(new ServiceDescriptor(
    typeof(ICityService), typeof(CityService), ServiceLifetime.Transient));
var app = builder.Build();


app.UseStaticFiles();
app.UseRouting();
app.MapControllers();

app.Run();
