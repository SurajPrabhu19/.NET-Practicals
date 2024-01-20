var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews(); // for creating Controller and Service objects
var app = builder.Build();

app.UseStaticFiles();
app.MapControllers(); // creates route for each Actions in the Controller
//app.MapControllerRoute(
//    name: "default", 
//    pattern: "{controller=Home}/{View=Index}"); //Convention based routing 

  // attribute based routing -> add routes in Controllers

app.Run();
