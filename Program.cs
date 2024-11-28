var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddControllersWithViews();

var app = builder.Build();

app.MapControllers();

app.MapControllerRoute("Default", "{controller=HomeController}/{action=Index}");

//app.MapGet("/", () => "Hello World!");

app.Run();
