var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.Run((context) => { return context.Response.WriteAsync("Inside Run Method"); }); 
// run() -> basically a terminating or short-circuit extension 
// i.e no command will run after this extension is executed

app.Run();
