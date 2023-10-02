//using Lab1PhArOh.DataSource;          COMPLETE ----------------
//using Microsoft.EntityFrameworkCore;   COMPLETE ----------------
//using WebServerAppExam.Data;           COMPLETE ----------------

using Microsoft.EntityFrameworkCore;
using WebServerAppExam.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container. // Important!!!-----------------------
builder.Services.AddRazorPages();

builder.Services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(
    builder.Configuration.GetConnectionString("DefaultConnection")
    )); // Important!!!-----------------------

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

app.UseAuthorization();

app.MapRazorPages();

app.Run();
