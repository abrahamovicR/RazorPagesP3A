using Microsoft.EntityFrameworkCore;
using RazorPages.Data;
using RazorPages.Models;
using Microsoft.AspNetCore.Identity;

var builder = WebApplication.CreateBuilder(args);
var connectionString = builder.Configuration.GetConnectionString("RazorPagesContextConnection") ?? throw new InvalidOperationException("Connection string 'RazorPagesContextConnection' not found.");;

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddDbContext<DataContext>(options =>
    options.UseSqlite("Data Source=app.db"));

builder.Services.AddDefaultIdentity<RazorPagesUser>(options =>
{
    options.SignIn.RequireConfirmedAccount = true;
    options.Password.RequireDigit = false;
    options.Password.RequireLowercase = false;
    options.Password.RequireUppercase = false;
    options.Password.RequireNonAlphanumeric = false;
    options.Password.RequiredLength = 2;
    options.Password.RequiredUniqueChars = 0;
}).AddRoles<IdentityRole>()
    .AddEntityFrameworkStores<DataContext>();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseRouting();

app.UseAuthentication(); // 1. Nejdřív ověříme identitu (Kdo jsi?)
app.UseAuthorization();  // 2. Pak řešíme práva (Co smíš?)

app.MapStaticAssets();
app.MapRazorPages()
   .WithStaticAssets();

app.Run();
