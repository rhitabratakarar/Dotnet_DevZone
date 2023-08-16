using Karttt.Classes;
using Karttt.Db;
using Karttt.Interfaces;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

static bool CanDatabaseBeConnected(string connectionString)
{
    if (connectionString != null || connectionString != "")
    {
        try
        {
            using SqlConnection conn = new(connectionString);
            conn.Open();
            return true;
        }
        catch (Exception)
        {
            return false;
        }
    }
    else
    {
        return false;
    }
}

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddScoped<IKartItemGenerator, KartItemGenerator>();
builder.Configuration.AddUserSecrets<Program>();
string? connString = builder.Configuration.GetConnectionString("KartttDb");

builder.Services.AddDbContext<KartDbContext>(options =>
{
    bool canBeConnected = CanDatabaseBeConnected(connString!);
    if (canBeConnected)
    {
        options.UseSqlServer(connString);
    }
    else
    {
        System.Diagnostics.Debug.WriteLine("Failed to connect to sql server. Falling back to InMemoryDatabase.");
        options.UseInMemoryDatabase("KartttDb");
    }
});
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
