using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using EF_DBFirst.Data;
using EF_DBFirst.Services;
using EF_DBFirst.Models;

var builder = WebApplication.CreateBuilder(args);
var connectionString = builder.Configuration.GetConnectionString("EF_DBFirstContextConnection") ?? throw new InvalidOperationException("Connection string 'EF_DBFirstContextConnection' not found.");

//here change identitycontext to NorthWindContext to play around NorthWind data
builder.Services.AddDbContext<NorthWindContext>(options =>
    options.UseSqlServer(connectionString));

builder.Services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
    .AddEntityFrameworkStores<NorthWindContext>();

// Add services to the container.
builder.Services.AddTransient<IDataService, DataService>();
builder.Services.AddRazorPages();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}
app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();
app.UseAuthentication();;

app.UseAuthorization();

app.MapRazorPages();

app.Run();
