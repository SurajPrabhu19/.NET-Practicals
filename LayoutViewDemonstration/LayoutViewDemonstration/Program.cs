var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();
var app = builder.Build();


//app.MapControllerRoute(
//    name: "default", 
//    pattern: "{controller=Home}/{View=Index}"); //Convention based routing 

app.MapControllers();   // attribute based routing -> add routes in Controllers

app.Run();
