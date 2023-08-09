using Karttt.Classes;
using Karttt.Db;
using Karttt.Interfaces;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddScoped<IKartItemGenerator, KartItemGenerator>();
builder.Configuration.AddUserSecrets<Program>();
string? connString = builder.Configuration.GetConnectionString("KartttDb");
builder.Services.AddDbContext<KartDbContext>(options => options.UseSqlServer(connString));
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

app.UseAuthorization();

app.MapRazorPages();

app.Run();
