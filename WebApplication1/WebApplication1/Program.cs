
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
    //if(request.Headers.ContainsKey("AuthorizationKey"))
    //{
    //    var auth = request.Headers["AuthorizationKey"];
    //    await response.WriteAsync($"<p>{auth}</p>");
    //}

    StreamReader reader = new StreamReader(request.Body);
    String body = await reader.ReadToEndAsync();    // await converts a Task to String and returns it

    await response.WriteAsync($"<h1>{body}</h1>");


});

app.Run();
 