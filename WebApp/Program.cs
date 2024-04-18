using Microsoft.EntityFrameworkCore;
using WebApp;
using WebApp.Models;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddScoped<BrandRepository>();
builder.Services.AddScoped<StudentRepository>();
builder.Services.AddDbContext<StoreContext>(p => p.UseSqlServer(builder.Configuration.GetConnectionString("Store")));
builder.Services.AddMvc();
var app = builder.Build();

//app.MapGet("/", () => "Hello World");
app.UseMiddleware<ModifyHeadersMiddleware>();
app.UseStaticFiles();
app.MapDefaultControllerRoute(); // dạng viết tắt
//app.MapControllerRoute(name: "default", pattern: "{controller = home}/{action = index}/{id?}");

app.Run();
