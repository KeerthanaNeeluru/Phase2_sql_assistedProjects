using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using P3S4Scaffolding.Data;
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<P3S4ScaffoldingDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("P3S4ScaffoldingDbContext") ?? throw new InvalidOperationException("Connection string 'P3S4ScaffoldingDbContext' not found.")));

// Add services to the container.
builder.Services.AddControllersWithViews();

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
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
