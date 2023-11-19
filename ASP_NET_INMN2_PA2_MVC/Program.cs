using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using ASP_NET_INMN2_PA2_MVC.Data;
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<INMN2_PA2_MVCContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("INMN2_PA2_MVCContext") ?? throw new InvalidOperationException("Connection string 'INMN2_PA2_MVCContext' not found.")));

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
