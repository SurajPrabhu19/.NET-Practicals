
//var builder = WebApplication.CreateBuilder();
//var app = builder.Build();

//app.Run(async (HttpContext context)=>{
//    var request = context.Request;
//    var response = context.Response;

//    response.ContentType = "text/html";
//    if(request.Headers.ContainsKey("User-agent"))
//    {
//        var userAgent  = request.Headers.UserAgent.ToString();
//        await context.Response.WriteAsync($"<h1>{userAgent}</h1>");
//    }
//});
//app.Run();


var builder = WebApplication.CreateBuilder();
var app = builder.Build();

app.Run(async (HttpContext context) =>
{
    var request = context.Request;
    var response = context.Response;

    response.ContentType = "text/html";
    if(request.Headers.ContainsKey("AuthorizationKey"))
    {
        var auth = request.Headers["AuthorizationKey"];
        await response.WriteAsync($"<p>{auth}</p>");
    }

});

app.Run();
 