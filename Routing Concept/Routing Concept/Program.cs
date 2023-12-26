var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews(); // adding this will make it suitable for MVC
                                            //  Further, if you want Pages features in your MVC application,
                                            //  then you need to use the AddMvc() method.

var app = builder.Build();

//app.MapGet("/", () => "Hello World!");
app.MapDefaultControllerRoute();

//app.MapControllerRoute();



app.Run();
