var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews(); // adding this will make it suitable for MVC
                                            //  Further, if you want Pages features in your MVC application,
                                            //  then you need to use the AddMvc() method.
                                            // REFER: https://dotnettutorials.net/lesson/difference-between-addmvc-and-addmvccore-method/

var app = builder.Build();

//app.MapGet("/", () => "Hello World!");
//app.MapDefaultControllerRoute();

// https://localhost:7065/ -> will call https://localhost:7065/Home/Welcome as the default url
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Welcome}/{id?}"
    );



app.Run();
