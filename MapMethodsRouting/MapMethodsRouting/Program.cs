var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

//app.MapGet("/", () => "Hello World!");
app.Map("/Home", () => "Universal map function that takes all kind of result");
app.MapGet("/Home", () => "Map Get Function");
app.MapPost("/Home", () => "Map Post Function");
app.MapPut("/Home", () => "Map Put Function");
app.MapDelete("/Home", () => "Map Delete Function");
// here for each route || "/Home" || we have a delegate function i.e. || () => {"Hello"} || also know as request delegate



app.Run();
