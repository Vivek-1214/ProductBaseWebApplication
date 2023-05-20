using Microsoft.EntityFrameworkCore;
using ProductBaseWebApplication.BAL;
using ProductBaseWebApplication.DAL;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddScoped< IproductListService , ProductListService>();


builder.Services.AddDbContext<ProductContext>(option => option.UseSqlServer(
   builder.Configuration.GetConnectionString("DemoCS") ) );

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=ProductList}/{action=Index}/{id?}");

app.Run();
