using BusinnesLayer.FluentValidation;
using DataAccessLayer.Concrete;
using Demo_Product.Models;
using EntityLayer.Concrete;
using FluentValidation;
using FluentValidation.AspNetCore;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.Authorization;

var builder = WebApplication.CreateBuilder(args);

// --- HOCANIN EKLEDİĞİ KISIM (builder.Services olarak düzeltildi) ---
builder.Services.AddDbContext<Context>();
builder.Services.AddIdentity<AppUser, AppRole>().AddEntityFrameworkStores<Context>().AddErrorDescriber<CustomIdentityValidator>();

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddMvc(config =>
{
    var policy=new AuthorizationPolicyBuilder()
    .RequireAuthenticatedUser()
    .Build();
    config.Filters.Add(new AuthorizeFilter(policy));
});

builder.Services.ConfigureApplicationCookie(options =>
{
    options.LoginPath = "/Login/Index/";
});

// Yeni Modern Kayıt Şekli (Senin eklediğin kısım):
builder.Services.AddFluentValidationClientsideAdapters();
builder.Services.AddValidatorsFromAssemblyContaining<ProductValidator>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseRouting();

// Identity kullandığımız için Authentication (Kimlik Doğrulama) da genelde buraya eklenir. 
app.UseAuthentication(); // İleride hoca bunu eklemeni isteyecek, şimdilik yorum satırında kalsın.

app.UseAuthorization();
app.MapStaticAssets();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}")
    .WithStaticAssets();

app.Run();
