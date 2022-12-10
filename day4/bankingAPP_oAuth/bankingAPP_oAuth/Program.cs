using bankingAPP_oAuth.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(connectionString));
builder.Services.AddDatabaseDeveloperPageExceptionFilter();

//builder.Services.AddAuthentication().AddFacebook(fb =>
//{
//    fb.AppId = "448407570829735";
//    fb.AppSecret = "f6bea4c918c6d1fdc0d80bce9ac9d59e";
//});

//builder.Services.AddAuthentication().AddGoogle(ggl =>
//{
//    ggl.ClientId = "308212338494-p876f66ki80fukm8lu18coba2im8p04h.apps.googleusercontent.com";
//    ggl.ClientSecret = "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";
//});

//builder.Services.AddAuthentication().AddTwitter(ttr =>
//{
//    ttr.ConsumerKey = "54p9584938594385943859834";
//    ttr.ConsumerSecret = "fdsjlkfshghsghruighhgudfgdf";
//});

builder.Services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
    .AddEntityFrameworkStores<ApplicationDbContext>();
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseMigrationsEndPoint();
}
else
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");
app.MapRazorPages();

app.Run();
