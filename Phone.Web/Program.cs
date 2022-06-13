using Phone.Web;
using Phone.Web.Services;
using Phone.Web.Services.IServices;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
/// <summary>
/// creating http dependencies
/// </summary>
builder.Services.AddHttpClient<IGoodService, GoodService>();
SD.GoodAPIBase = builder.Configuration["ServiceUrl:GoodAPI"];
builder.Services.AddScoped<IGoodService, GoodService>();    
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
