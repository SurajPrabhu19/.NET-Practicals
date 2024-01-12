var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews(); // adding this will make it suitable for MVC
                                            //  Further, if you want Pages features in your MVC application,
                                            //  then you need to use the AddMvc() method.
                                            // REFER: https://dotnettutorials.net/lesson/difference-between-addmvc-and-addmvccore-method/

var app = builder.Build();

//app.MapGet("/", () => "Hello World!");      // callback function

// CONVENTION based ROUTING: ------------------------------------------------------------------
//app.MapDefaultControllerRoute();

// https://localhost:7065/ -> will call https://localhost:7065/Home/Welcome as the default url
//app.MapControllerRoute(
//    name: "default",
//    pattern: "{controller=Home}/{action=Welcome}/{id?}"
//    );
//---------------------------------------------------------------------------------------------

//// ATTRIBUTE based ROUTING: -------------------------------------------------------------------
//app.MapControllers();

////---------------------------------------------------------------------------------------------
//// ENDPOINT based ROUTING: -------------------------------------------------------------------
//app.UseRouting();
//app.Use(async (context, next) =>
//{
//    Microsoft.AspNetCore.Http.Endpoint endpoint = context.GetEndpoint();    // this will work only once the UseRouting() is enabled
//    await context.Response.WriteAsync($"the endpoint displayname is {endpoint.DisplayName}");
//    await context.Response.WriteAsync($"the endpoint metadata is {endpoint.Metadata}");
//    await next(context);
//});
//app.UseEndpoints(endpoints =>
//{
//    endpoints.Map("map1", async (context) => { await context.Response.WriteAsync("Route for localhost:portNo/map1"); });
//    endpoints.Map("map2", async (context) => { await context.Response.WriteAsync("Route for localhost:portNo/map2"); });
//    endpoints.MapGet("map1get", async (context) => { await context.Response.WriteAsync("Route for localhost:portNo/map1Get"); });
//    endpoints.MapPost("map2post", async (context) => { await context.Response.WriteAsync("Route for localhost:portNo/map2post"); });
//});

////---------------------------------------------------------------------------------------------

// ENDPOINT based ROUTING: Using Query Param: ---------------------------------------------------
app.UseRouting();

app.UseEndpoints(endpoints =>
{
    endpoints.Map("/files/{filename}.{extension}",
        async (context) =>
        {
            await context.Response.WriteAsync("Inside Files folder - filename and extension provided");
        });
    endpoints.Map("/files/{filenumber=1}",
        async (context) =>
        {
            await context.Response.WriteAsync("Inside Files folder - default param");
        });
    // primitive contstaints involve: int, bool, datetime, decimal(-2, 0.02), long, guid({5F440509-2E7A-4454-8F4B-E9EB8BA75B09}) - global universal identifier - 128bit hexa decimal number
    endpoints.Map("/files/{filenumber:int?}",   
        async (context) =>
        {
            await context.Response.WriteAsync("Inside Files folder - Nullable filenumber");
        });
    endpoints.Map("/files/{filenumber:guid}",   
        async (context) =>
        {
            Guid guid = Guid.Parse(Convert.ToString(context.Request.RouteValues["filenumber"])!);   ///! indicates value cannot be null
            await context.Response.WriteAsync($"Inside Files folder - Guid number: {guid}");
        });
    endpoints.Map("/files/{filename:minlength(1):maxlength(10)}",  // OR use length(1,10) 
        async (context) =>
        {
            Guid guid = Guid.Parse(Convert.ToString(context.Request.RouteValues["filenumber"])!);   ///! indicates value cannot be null
            await context.Response.WriteAsync($"Inside Files folder - Guid number: {guid}");
        });
    //{id:int:range(1,100)} - Range Constraint
    // {name:alpha} - alphabets only 
    // {age:regex(^[0-9]{2}$)} - Regex expression constraint - to match 2 digits numbers
});
//---------------------------------------------------------------------------------------------
app.Run(async (context) =>
{
    await context.Response.WriteAsync($"Request received on {context.Request.Path}");

});
