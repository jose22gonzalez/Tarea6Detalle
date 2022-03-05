using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Tarea6Detalle.Data;
using Tarea6Detalle.DAL;
using Microsoft.EntityFrameworkCore;
using Tarea6Detalle.BLL;
using Blazored.Toast;



var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddSingleton<WeatherForecastService>();
builder.Services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();

builder.Services.AddBlazoredToast();

builder.Services.AddDbContext<Contexto>(options =>
    options.UseSqlite(builder.Configuration.GetConnectionString("ConStr"))
    );

builder.Services.AddTransient<ProductosBBL>();

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

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();
