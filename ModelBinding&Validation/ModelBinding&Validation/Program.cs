using ModelBinding_Validation.CustomModelBinder;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddHttpClient();
builder.Services.AddControllersWithViews(options =>
{
    options.ModelBinderProviders.Insert(0, new CustomEmployeeBinderProvider());
});
//builder.Services.AddControllersWithViews().AddXmlSerializerFormatters();
// u have to add this in case you are passing xml data in request body
// since aspnetcore has JsonInputFormatter as the default choice
/*
 * Takes data from RequestBody and auto converts it into an XML:
 * <Employee>
 *      <name>Suraj Prabhu</name>
 *      <email>sp@gmail.com</email>
 * </Employee>
 */

var app = builder.Build();
//app.MapGet("/", () => "Hello World!");

app.UseRouting();
app.MapControllers();

app.Run();
