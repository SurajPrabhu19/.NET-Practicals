//var builder = WebApplication.CreateBuilder(args);
//var app = builder.Build();

//app.Run(async (HttpContext context) => { 
//    context.Response.StatusCode = 200;
//    context.Response.Headers["TempKey"] = "this is just a demo header";
//    context.Response.Headers["Server"] = "my server"; // the change in name wont change the Server - by def its KESTREL for ASP.NET Core
//    context.Response.ContentType = "text/html";
//    // text/plain, text/html, application/json, application/xml // these are the various content types you use
//    // content length will be assigned by the kestrel server depending on the content-type
//    await context.Response.WriteAsync("<h1>Response Header</h1>");
//    await context.Response.WriteAsync("<h2>Date: Date when the response was sent</h2>");
//    await context.Response.WriteAsync("<h2>Server</h2>");
//    await context.Response.WriteAsync("<h2>Content-Type</h2>");
//    await context.Response.WriteAsync("<h2>Content-Length</h2>");
//    await context.Response.WriteAsync("<h2>Cache-Control: indicates the no of seconds that a response can be cached AT BROWSER- max-age=60</h2>");
//    await context.Response.WriteAsync("<h2>Cookie-Control: Contains cookie to send TO BROWSER- x=10</h2>");
//    await context.Response.WriteAsync("<h2>Access-Control-Allow-Origin: Used to enable CORS</h2>");
//    await context.Response.WriteAsync("<h2>Location: Contains URL to redirect</h2>");
//    await context.Response.WriteAsync("<h4>Refer MDN doc for more details</h4>");

//});
////Worldpp.MapGet("/", () => "Hello World!");

//app.Run();

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();



app.Run(async (HttpContext context) =>
{
    var request = context.Request;
    var header = request.Headers;


    string host = request.Host+"";
    String requestType = request.Method;


    context.Response.Headers["Content-type"] = "text/html";
    await context.Response.WriteAsync($"<p>{host}</p>");
    await context.Response.WriteAsync($"<p>{requestType}</p>");
});

app.Run();

 