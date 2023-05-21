using Ecommerce.BLL.Abstract;
using Ecommerce.BLL.AbstractService;
using Ecommerce.BLL.Concrete;
using Ecommerce.BLL.Service;
using ECommerce.DAL.Context;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

//Services

builder.Services.AddDbContext<EcommerceContext>();



builder.Services.AddTransient(typeof(IRepository<>), typeof(BaseRepository<>));
builder.Services.AddScoped<ICategoryService, CategoryService>();

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
