﻿using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using WebApplication9.Data;
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<ContactData>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("ContactData") ?? throw new InvalidOperationException("Connection string 'ContactData' not found.")));
builder.Services.AddDbContext<WebApplication9Context>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("WebApplication9Context") ?? throw new InvalidOperationException("Connection string 'WebApplication9Context' not found.")));

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
